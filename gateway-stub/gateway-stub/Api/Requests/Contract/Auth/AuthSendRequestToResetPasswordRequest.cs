using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Auth
{
    public class AuthSendRequestToResetPasswordRequest : IContractRequestData
    {
        public readonly string Email;

        public AuthSendRequestToResetPasswordRequest(string email)
        {
            Email = email;
        }
    }
}