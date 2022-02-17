using System.Threading.Tasks;
using GatewayStub.Domain.Models.Json;

namespace GatewayStub.Domain.Services
{
    public interface IMatchmakingService
    {
        RoomConfig RoomConfig { get; }
        Task StartMatchmaking();
    }
}