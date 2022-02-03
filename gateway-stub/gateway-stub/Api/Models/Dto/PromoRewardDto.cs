using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class PromoRewardDto : INetSerialize
    {
        public string RewardType;
        public string CurrencyKey;
        public string CurrencyAmount;
        public byte HeroId;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(RewardType);
            writer.Write(CurrencyKey);
            writer.Write(CurrencyAmount);
            writer.Write(HeroId);
        }

        public void NetDeserialize(ByteReader reader)
        {
            RewardType = reader.ReadString();
            CurrencyKey = reader.ReadString();
            CurrencyAmount = reader.ReadString();
            HeroId = reader.ReadByte();
        }
    }
}