using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Balances
{
    public class BalancesFreeExperienceAddedNotification : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Balances;
        public override byte MethodId => (byte) EMethodId.BalancesFreeExperienceAddedNotification;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly int Amount;
        public readonly int Balance;

        public BalancesFreeExperienceAddedNotification(EGatewayErrorCode errorCode, int amount, int balance)
        {
            ErrorCode = errorCode;
            Amount = amount;
			Balance = balance;
		}

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(Amount);
            writer.Write(Balance);
        }
    }
}