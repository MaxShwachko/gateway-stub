using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Auth
{
    public class AuthSendRequestToResetPasswordResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Auth;
        public override byte MethodId => (byte) EMethodId.AuthSendRequestToResetPassword;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly bool Success;

        public AuthSendRequestToResetPasswordResponse(EGatewayErrorCode errorCode, bool success)
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