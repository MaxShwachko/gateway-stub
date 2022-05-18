using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Auth
{
    public class AuthLoginResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Auth;
        public override byte MethodId => (byte) EMethodId.AuthLogin;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly string AccessToken;
        public readonly int ExpiresIn;
        public readonly int RefreshExpiresIn;
        public readonly string RefreshToken;
        public readonly string UserId;

        public AuthLoginResponse(EGatewayErrorCode errorCode, string accessToken, int expiresIn, int refreshExpiresIn,
            string refreshToken, string userId)
        {
            ErrorCode = errorCode;
            AccessToken = accessToken;
            ExpiresIn = expiresIn;
            RefreshExpiresIn = refreshExpiresIn;
            RefreshToken = refreshToken;
            UserId = userId;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(AccessToken);
            writer.Write(ExpiresIn);
            writer.Write(RefreshExpiresIn);
            writer.Write(RefreshToken);
            writer.Write(UserId);
        }
    }
}