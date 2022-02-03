using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class UserGetSettingsResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.UserGetSettings;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly bool Music;
        public readonly bool Sounds;
        public readonly byte Language;
        public readonly byte Quality;
        public readonly byte HfrEffects;
        public readonly bool IsChanged;

        public UserGetSettingsResponse(EGatewayErrorCode errorCode, bool music, bool sounds, byte language, byte quality, byte hfrEffects, bool isChanged)
        {
            ErrorCode = errorCode;
            Music = music;
            Sounds = sounds;
            Language = language;
            Quality = quality;
            HfrEffects = hfrEffects;
            IsChanged = isChanged;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(Music);
            writer.Write(Sounds);
            writer.Write(Language);
            writer.Write(Quality);
            writer.Write(HfrEffects);
            writer.Write(IsChanged);
        }
    }
}