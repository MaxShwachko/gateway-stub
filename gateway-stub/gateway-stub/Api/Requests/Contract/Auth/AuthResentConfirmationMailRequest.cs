using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Auth
{
    public class AuthResentConfirmationMailRequest : IContractRequestData
    {
        public readonly string Email;

        public AuthResentConfirmationMailRequest(string email)
        {
            Email = email;
        }
    }
}