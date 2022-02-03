using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.GameBalancer
{
    public class GameBalancerStopSearchingResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.GameBalancer;
        public override byte MethodId => (byte) EMethodId.GameBalancerStopSearching;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly bool IsSuccess;

        public GameBalancerStopSearchingResponse(EGatewayErrorCode errorCode, bool isSuccess)
        {
            ErrorCode = errorCode;
            IsSuccess = isSuccess;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(IsSuccess);
        }
    }
}