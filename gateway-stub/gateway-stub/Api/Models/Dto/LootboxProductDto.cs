using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class LootboxProductDto : INetSerialize
    {
        public int LootboxId;
        public int Type;
        public string ProductType;
        public string CurrencyType;
        public string Price;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(LootboxId);
            writer.Write(Type);
            writer.Write(ProductType);
            writer.Write(CurrencyType);
            writer.Write(Price);
        }

        public void NetDeserialize(ByteReader reader)
        {
            LootboxId = reader.ReadInt32();
            Type = reader.ReadInt32();
            ProductType = reader.ReadString();
            CurrencyType = reader.ReadString();
            Price = reader.ReadString();
        }
    }
}