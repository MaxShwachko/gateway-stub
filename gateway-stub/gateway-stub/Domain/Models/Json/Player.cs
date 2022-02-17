using System;

namespace GatewayStub.Domain.Models.Json
{
    [Serializable]
    public class Player
    {
        public string id;
        public string authToken;
        public byte heroId;
        public HeroStats heroStats;
        public byte team;
    }
}