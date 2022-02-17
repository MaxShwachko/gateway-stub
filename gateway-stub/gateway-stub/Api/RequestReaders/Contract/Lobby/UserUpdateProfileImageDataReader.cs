using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Lobby;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Lobby
{
    public class UserUpdateProfileImageDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.UserUpdateProfileImage;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            return new UserUpdateProfileImageRequest(reader.ReadByte());
        }
    }
}