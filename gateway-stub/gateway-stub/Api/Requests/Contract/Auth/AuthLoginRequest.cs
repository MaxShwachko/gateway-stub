using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Auth
{
    public class AuthLoginRequest : IContractRequestData
    {
        public readonly string Username;
        public readonly string Password;
        public readonly string DeviceId;

        public AuthLoginRequest(string username, string password, string deviceId)
        {
            Username = username;
            Password = password;
            DeviceId = deviceId;
        }
    }
}