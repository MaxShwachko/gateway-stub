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
        public readonly int RoomId;
        public readonly string RoomHost;
        public readonly int RoomTcpPort;
        public readonly int RoomUdpPort;
        public readonly byte TeamId;
        public readonly NetList<PlayerDataDto> Players;

        public Checkin(bool success, string apiVersion, string authToken, int roomId, string roomHost, int roomTcpPort, int roomUdpPort, byte teamId, NetList<PlayerDataDto> players)
        {
            Success = success;
            ApiVersion = apiVersion;
            AuthToken = authToken;
            RoomId = roomId;
            RoomHost = roomHost;
            RoomTcpPort = roomTcpPort;
            RoomUdpPort = roomUdpPort;
            TeamId = teamId;
            Players = players;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write(Success);
            writer.Write(ApiVersion);
            writer.Write(AuthToken);
            writer.Write(RoomId);
            writer.Write(RoomHost);
            writer.Write(RoomTcpPort);
            writer.Write(RoomUdpPort);
            writer.Write(TeamId);
            Players.NetSerialize(writer);
        }
    }
}