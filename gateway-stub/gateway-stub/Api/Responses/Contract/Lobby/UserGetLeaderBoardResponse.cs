using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class UserGetLeaderBoardResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.UserGetLeaderBoard;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly short Page;
        public readonly short Pages;
        public readonly NetList<LeaderboardPlaceDto> Leaderboard;

        public UserGetLeaderBoardResponse(EGatewayErrorCode errorCode, short page, short pages, NetList<LeaderboardPlaceDto> leaderboard)
        {
            ErrorCode = errorCode;
            Page = page;
            Pages = pages;
            Leaderboard = leaderboard;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(Page);
            writer.Write(Pages);
            Leaderboard.NetSerialize(writer);
        }
    }
}