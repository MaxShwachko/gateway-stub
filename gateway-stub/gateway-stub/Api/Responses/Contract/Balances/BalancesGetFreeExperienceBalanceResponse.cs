using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Balances
{
    public class BalancesGetFreeExperienceBalanceResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Balances;
        public override byte MethodId => (byte) EMethodId.BalancesGetFreeExperienceBalance;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly int Amount;

        public BalancesGetFreeExperienceBalanceResponse(EGatewayErrorCode errorCode, int amount)
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