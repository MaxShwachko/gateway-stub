using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Auth
{
    public class AuthSetPasswordResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Auth;
        public override byte MethodId => (byte) EMethodId.AuthSetPassword;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly string AccessToken;
        public readonly int ExpiresIn;
        public readonly string IdToken;
        public readonly int RefreshExpiresIn;
        public readonly string RefreshToken;
        public readonly string UserId;

        public AuthSetPasswordResponse(EGatewayErrorCode errorCode, string accessToken, int expiresIn, string idToken,
            int refreshExpiresIn, string refreshToken, string userId)
        {
            ErrorCode = errorCode;
            AccessToken = accessToken;
            ExpiresIn = expiresIn;
            IdToken = idToken;
            RefreshExpiresIn = refreshExpiresIn;
            RefreshToken = refreshToken;
            UserId = userId;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(AccessToken);
            writer.Write(ExpiresIn);
            writer.Write(IdToken);
            writer.Write(RefreshExpiresIn);
            writer.Write(RefreshToken);
            writer.Write(UserId);
        }
    }
}