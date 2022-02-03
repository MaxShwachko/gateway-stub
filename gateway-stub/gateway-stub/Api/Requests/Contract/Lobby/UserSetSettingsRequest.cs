using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Lobby
{
    public class UserSetSettingsRequest : IContractRequestData
    {
        public readonly bool Sounds;
        public readonly bool Music;
        public readonly byte Quality;
        public readonly byte HfrEffects;
        public readonly byte Language;

        public UserSetSettingsRequest(bool sounds, bool music, byte quality, byte hfrEffects, byte language)
        {
            Sounds = sounds;
            Music = music;
            Quality = quality;
            HfrEffects = hfrEffects;
            Language = language;
        }
    }
}