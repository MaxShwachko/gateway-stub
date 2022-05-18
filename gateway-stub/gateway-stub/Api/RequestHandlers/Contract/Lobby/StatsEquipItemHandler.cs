using System;
using System.Linq;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Lobby;
using GatewayStub.Api.Responses.Contract.ListeriaStorage;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class StatsEquipItemHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.EquipmentEndpointsEquipItem;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public StatsEquipItemHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            var statsEquipHeroRequest = (StatsEquipItemRequest) request;
            Console.WriteLine("StatsEquipItem message received");
            var equipment = _dataContext.Equipment;
            await _socket.Send(new StatsEquipItemResponse(EGatewayErrorCode.Success, statsEquipHeroRequest.BindingUid,
                statsEquipHeroRequest.SlotUid, equipment.EquipmentBonuses, statsEquipHeroRequest.HeroUid));
            
            var heroDto = _dataContext.Heroes.AvailableHeroes.FirstOrDefault(h => h.BindingUid == statsEquipHeroRequest.HeroUid);
            heroDto.EquipmentBonuses.Strength = (Int32.Parse(heroDto.EquipmentBonuses.Strength) + 10).ToString();
            await _socket.Send(new HeroesStatsUpdatedNotification(EGatewayErrorCode.Success, heroDto, EStatsUpdateReason.Equip));
        }
    }
}