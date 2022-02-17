using System;
using System.Linq;
using System.Threading.Tasks;
using GatewayStub.Api.Models.Dto;
using GatewayStub.Api.Responses.Contract.Room;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;
using GatewayStub.Domain.Services;
using Microsoft.AspNetCore.Http;

namespace GatewayStub.Api.HttpHandlers
{
    public class RoomReadyHandler : IHttpHandler
    {
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;
        private readonly IMatchmakingService _matchmakingService;
        public string Route => "ready";

        public RoomReadyHandler(IWebSocketWrapper socket, IDataContext dataContext,
            IMatchmakingService matchmakingService)
        {
            _socket = socket;
            _dataContext = dataContext;
            _matchmakingService = matchmakingService;
        }

        public async Task<int> Handle(HttpRequest request)
        {
            Console.WriteLine("RoomReadyHandler handle");

            var checkinSuccess = _dataContext.Matchmaking.CheckinSuccess;
            var apiVersion = _dataContext.Matchmaking.ApiVersion;
            var authToken = _dataContext.Matchmaking.AuthToken;
            var proxyIp = _matchmakingService.RoomConfig.proxyIp;
            var tcpPort = _dataContext.Matchmaking.ProxyTcpPort;
            var roomId = _matchmakingService.RoomConfig.roomId;
            var roomHost = _dataContext.Matchmaking.RoomHost;
            var roomPort = _matchmakingService.RoomConfig.roomPort;
            var teamId = _dataContext.Matchmaking.TeamId;
            var players = _matchmakingService.RoomConfig.players;
            var playersList = new NetList<PlayerDataDto>(); //TODO : remove after AutoMapper adding
            playersList.AddRange(players.Select(player => new PlayerDataDto
            {
                Nick = $"{player.id} - {player.heroId}",
                HeroId = player.heroId,
                PlayerId = player.id,
                HeroStats = new HeroStatsDto
                {
                    Agility = player.heroStats.agility,
                    Armor = player.heroStats.armor,
                    Health = player.heroStats.health,
                    Intelligence = player.heroStats.intelligence,
                    Strength = player.heroStats.strength,
                    AttackDamage = player.heroStats.attackDamage,
                    MainStat = player.heroStats.mainStat,
                    MoveSpeed = player.heroStats.moveSpeed,
                    SkillPower = player.heroStats.skillPower,
                    UltPower = player.heroStats.ultPower,
                    VampirismPower = player.heroStats.vampirismPower,
                    AttackReloadSpeed = player.heroStats.attackReloadSpeed,
                    HealthRegenPercent = player.heroStats.healthRegenPercent,
                    SkillEffectPower = player.heroStats.skillEffectPower,
                    UltEffectPower = player.heroStats.ultEffectPower
                }
            }));

            await _socket.Send(new Checkin(
                    checkinSuccess, apiVersion, authToken, proxyIp, tcpPort, roomId, roomHost, roomPort, teamId, playersList));
            return StatusCodes.Status200OK;
        }
    }
}