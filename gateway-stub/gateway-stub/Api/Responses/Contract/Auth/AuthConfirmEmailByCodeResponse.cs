using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Auth
{
    public class AuthConfirmEmailByCodeResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Auth;
        public override byte MethodId => (byte) EMethodId.AuthConfirmEmailByCode;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly string PasswordHash;

        public AuthConfirmEmailByCodeResponse(EGatewayErrorCode errorCode, string passwordHash)
        {
            ErrorCode = errorCode;
            PasswordHash = passwordHash;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(PasswordHash);
        }
    }
}