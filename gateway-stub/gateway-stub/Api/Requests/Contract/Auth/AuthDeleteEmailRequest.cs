using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Auth
{
    public class AuthDeleteEmailRequest : IContractRequestData
    {
        public readonly string EmailHash;

        public AuthDeleteEmailRequest(string emailHash)
        {
            EmailHash = emailHash;
        }
    }
}