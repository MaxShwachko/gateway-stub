using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;

namespace GatewayStub.Domain.Models.Dao
{
    public class LeaderboardDao
    {
        public short CurrentPage;
        public short Pages;
        public NetList<LeaderboardPlaceDto> Leaderboard;
    }
}