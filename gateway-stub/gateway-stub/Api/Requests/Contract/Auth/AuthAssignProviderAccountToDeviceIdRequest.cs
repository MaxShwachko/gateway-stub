using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Auth
{
    public class AuthAssignProviderAccountToDeviceIdRequest : IContractRequestData
    {
        public readonly string Token;

        public AuthAssignProviderAccountToDeviceIdRequest(string token)
        {
            Token = token;
        }
    }
}