using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
    public class SpendExperienceResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Test;
        public override byte MethodId => (byte) EMethodId.SpendExperience;

        public readonly EGatewayErrorCode ErrorCode;

        public SpendExperienceResponse(EGatewayErrorCode errorCode)
        {
            ErrorCode = errorCode;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
        }
    }
}