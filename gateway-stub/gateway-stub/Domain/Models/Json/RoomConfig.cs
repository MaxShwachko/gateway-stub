using System;
using System.Collections.Generic;

namespace GatewayStub.Domain.Models.Json
{
    [Serializable]
    public class RoomConfig : ICloneable
    {
        public int roomId;
        public int tcpPort;
        public int roomPort;
        public string balancerUrl;
        public string balancerMessage;
        public string proxyIp;
        public List<Player> players;

        public object Clone()
        {
            var clone = new RoomConfig
            {
                roomId = this.roomId,
                tcpPort = this.tcpPort,
                roomPort = this.roomPort,
                balancerUrl = this.balancerUrl,
                balancerMessage = this.balancerMessage,
                proxyIp = this.proxyIp,
                players = this.players
            };

            clone.players = new List<Player>();
            clone.players.AddRange(players);

            return clone;
        }
    }
}