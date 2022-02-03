using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Lobby
{
    public class UserUpdateUsernameRequest : IContractRequestData
    {
        public readonly string NewUsername;

        public UserUpdateUsernameRequest(string newUsername)
        {
            NewUsername = newUsername;
        }
    }
}