using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class TransactionDto : INetSerialize 
    {
        public string BlockId;
        public string DateTime;
        public string BalanceChange;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(BlockId);
            writer.Write(DateTime);
            writer.Write(BalanceChange);
        }

        public void NetDeserialize(ByteReader reader)
        {
            BlockId = reader.ReadString();
            DateTime = reader.ReadString();
            BalanceChange = reader.ReadString();
        }
    }
}