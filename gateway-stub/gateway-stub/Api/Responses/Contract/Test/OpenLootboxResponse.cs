using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
    public class OpenLootboxResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Test;
        public override byte MethodId => (byte) EMethodId.OpenLootbox;

        public readonly EGatewayErrorCode ErrorCode;

        public OpenLootboxResponse(EGatewayErrorCode errorCode)
        {
            ErrorCode = errorCode;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
        }
    }
}