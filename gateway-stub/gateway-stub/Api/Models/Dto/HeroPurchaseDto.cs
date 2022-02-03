using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class HeroPurchaseDto : INetSerialize
    {
        public byte HeroId;
        public string ProductType;
        public string CurrencyType;
        public string Price;
        public HeroStatsDto HeroStats;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(HeroId);
            writer.Write(ProductType);
            writer.Write(CurrencyType);
            writer.Write(Price);
            HeroStats.NetSerialize(writer);
        }

        public void NetDeserialize(ByteReader reader)
        {
            HeroId = reader.ReadByte();
            ProductType = reader.ReadString();
            CurrencyType = reader.ReadString();
            Price = reader.ReadString();
            HeroStats = DTOSerializer.NetDeserialize<HeroStatsDto>(reader);
        }
    }
}