using GatewayStub.Domain.Models.Json;

namespace GatewayStub.Domain.Models.Dao
{
    public class MatchmakingDao
    {
        public bool StopSearchingSuccess;
        public bool StartSearchingSuccess;
        public bool CheckinSuccess;
        public RoomConfig RoomConfig;
        public string UserId;
        public string AuthToken;
        public byte TeamId;
        public string ApiVersion;
        public string RoomHost;
    }
}