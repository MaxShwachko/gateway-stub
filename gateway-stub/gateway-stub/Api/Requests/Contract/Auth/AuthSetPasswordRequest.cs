using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Auth
{
    public class AuthSetPasswordRequest : IContractRequestData
    {
        public readonly string PasswordHash;
        public readonly string Password;
        public readonly string DeviceId;

        public AuthSetPasswordRequest(string passwordHash, string password, string deviceId)
        {
            PasswordHash = passwordHash;
            Password = password;
            DeviceId = deviceId;
        }
    }
}