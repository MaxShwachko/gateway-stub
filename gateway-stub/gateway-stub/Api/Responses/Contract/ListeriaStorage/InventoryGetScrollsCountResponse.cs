using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.ListeriaStorage
{
    public class InventoryGetScrollsCountResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.ListeriaStorage;
        public override byte MethodId => (byte) EMethodId.InventoryGetScrollsCount;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly int Amount;

        public InventoryGetScrollsCountResponse(EGatewayErrorCode errorCode, int amount)
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