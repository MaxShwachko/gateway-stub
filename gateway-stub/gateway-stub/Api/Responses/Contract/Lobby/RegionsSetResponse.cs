using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class RegionsSetResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.RegionsSet;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly bool Success;

        public RegionsSetResponse(EGatewayErrorCode errorCode, bool success)
        {
            ErrorCode = errorCode;
            Success = success;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(Success);
        }
    }
}