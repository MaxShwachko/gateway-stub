using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Room
{
    public class Checkin : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Room;
        public override byte MethodId => (byte) EMethodId.Checkin;
        
        public readonly bool Success;
        public readonly string ApiVersion;
        public readonly string AuthToken;
        public readonly string ProxyIp;
        public readonly int ProxyTcpPort;
        public readonly int RoomId;
        public readonly string RoomHost;
        public readonly int RoomPort;
        public readonly byte TeamId;
        public readonly NetList<PlayerDataDto> Players;

        public Checkin(bool success, string apiVersion, string authToken, string proxyIp, int proxyTcpPort, int roomId, string roomHost, int roomPort, byte teamId, NetList<PlayerDataDto> players)
        {
            Success = success;
            ApiVersion = apiVersion;
            AuthToken = authToken;
            ProxyIp = proxyIp;
            ProxyTcpPort = proxyTcpPort;
            RoomId = roomId;
            RoomHost = roomHost;
            RoomPort = roomPort;
            TeamId = teamId;
            Players = players;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write(Success);
            writer.Write(ApiVersion);
            writer.Write(AuthToken);
            writer.Write(ProxyIp);
            writer.Write(ProxyTcpPort);
            writer.Write(RoomId);
            writer.Write(RoomHost);
            writer.Write(RoomPort);
            writer.Write(TeamId);
            Players.NetSerialize(writer);
        }
    }
}