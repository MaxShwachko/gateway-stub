using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Lobby;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Lobby
{
    public class UserGetLeaderBoardDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.UserGetLeaderBoard;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var page = reader.ReadInt16();

            return new UserGetLeaderBoardRequest(page);
        }
    }
}