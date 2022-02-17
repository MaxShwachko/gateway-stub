using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Lobby;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Lobby
{
    public class UserUpdateUsernameDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.UserUpdateUsername;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var username = reader.ReadString();

            return new UserUpdateUsernameRequest(username);
        }
    }
}