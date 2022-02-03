using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Transactions
{
    public class BalanceGetBalanceByUserIdResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Transactions;
        public override byte MethodId => (byte) EMethodId.BalanceGetBalanceByUserId;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly string Amount;

        public BalanceGetBalanceByUserIdResponse(EGatewayErrorCode errorCode, string amount)
        {
            ErrorCode = errorCode;
            Amount = amount;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(Amount);
        }
    }
}