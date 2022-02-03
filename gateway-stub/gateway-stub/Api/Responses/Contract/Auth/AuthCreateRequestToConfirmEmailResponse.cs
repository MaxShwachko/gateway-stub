using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Auth
{
    public class AuthCreateRequestToConfirmEmailResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Auth;
        public override byte MethodId => (byte) EMethodId.AuthCreateRequestToConfirmEmail;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly string EmailHash;

        public AuthCreateRequestToConfirmEmailResponse(EGatewayErrorCode errorCode, string emailHash)
        {
            ErrorCode = errorCode;
            EmailHash = emailHash;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(EmailHash);
        }
    }
}