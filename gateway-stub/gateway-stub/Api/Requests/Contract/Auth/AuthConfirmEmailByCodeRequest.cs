using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Auth
{
    public class AuthConfirmEmailByCodeRequest : IContractRequestData
    {
        public readonly string Code;
        public readonly string EmailHash;

        public AuthConfirmEmailByCodeRequest(string code, string emailHash)
        {
            Code = code;
            EmailHash = emailHash;
        }
    }
}