using System;
using System.Collections.Generic;

namespace GatewayStub.Domain.Models.Json
{
    [Serializable]
    public class RoomConfig : ICloneable
    {
        public int roomId;
        public int gameTcpPort;
        public int gameUdpPort;
        public string balancerUrl;
        public string roomReadyRoute;
        public string battleOverRoute;
        public string roomReadyMessage;
        public List<Player> players;

        public object Clone()
        {
            var clone = new RoomConfig
            {
                roomId = this.roomId,
                gameTcpPort = this.gameTcpPort,
                gameUdpPort = this.gameUdpPort,
                balancerUrl = this.balancerUrl,
                roomReadyRoute = this.roomReadyRoute,
                battleOverRoute = this.battleOverRoute,
                roomReadyMessage = this.roomReadyMessage,
                players = this.players
            };

            clone.players = new List<Player>();
            clone.players.AddRange(players);

            return clone;
        }
    }
}