using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Auth
{
    public class AuthResetPasswordRequest : IContractRequestData
    {
        public readonly string Hash;
        public readonly string NewPassword;

        public AuthResetPasswordRequest(string hash, string newPassword)
        {
            Hash = hash;
            NewPassword = newPassword;
        }
    }
}