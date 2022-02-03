using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Auth
{
    public class AuthConfirmPasswordRequest : IContractRequestData
    {
        public readonly string Password;

        public AuthConfirmPasswordRequest(string password)
        {
            Password = password;
        }
    }
}