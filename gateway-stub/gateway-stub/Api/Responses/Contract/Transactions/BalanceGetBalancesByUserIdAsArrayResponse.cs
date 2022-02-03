using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Transactions
{
    public class BalanceGetBalancesByUserIdAsArrayResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Transactions;
        public override byte MethodId => (byte) EMethodId.BalanceGetBalancesByUserIdAsArray;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<BalanceDto> Currencies;

        public BalanceGetBalancesByUserIdAsArrayResponse(EGatewayErrorCode errorCode, NetList<BalanceDto> currencies)
        {
            ErrorCode = errorCode;
            Currencies = currencies;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            Currencies.NetSerialize(writer);
        }
    }
}