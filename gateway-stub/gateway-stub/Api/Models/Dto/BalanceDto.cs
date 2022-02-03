using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class BalanceDto : INetSerialize
    {
        public string Key;
        public string Amount;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(Key);
            writer.Write(Amount);
        }

        public void NetDeserialize(ByteReader reader)
        {
            Key = reader.ReadString();
            Amount = reader.ReadString();
        }
    }
}