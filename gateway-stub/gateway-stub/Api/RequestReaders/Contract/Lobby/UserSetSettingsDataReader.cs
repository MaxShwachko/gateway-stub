using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Lobby;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Lobby
{
    public class UserSetSettingsDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.UserSetSettings;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var sounds = reader.ReadBoolean();
            var music = reader.ReadBoolean();
            var quality = reader.ReadByte();
            var hfrEffects = reader.ReadByte();
            var language = reader.ReadByte();

            return new UserSetSettingsRequest(sounds, music, quality, hfrEffects, language);
        }
    }
}