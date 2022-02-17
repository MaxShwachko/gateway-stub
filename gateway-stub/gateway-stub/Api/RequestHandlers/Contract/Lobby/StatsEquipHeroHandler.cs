using System;
using System.Linq;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Lobby;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class StatsEquipHeroHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.StatsEquipHero;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public StatsEquipHeroHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("StatsEquipHero message received");

            var equipHeroRequest = (StatsEquipHeroRequest) request;
            var selectedHeroUid = equipHeroRequest.BindingUid;
            var selectedHero = _dataContext.Heroes.AvailableHeroes.FirstOrDefault(h => h.BindingUid == selectedHeroUid);
            var equipHeroSuccess = _dataContext.Heroes.EquipHeroSuccess;

            if (selectedHero == null)
            {
                Console.WriteLine($"Couldn't find hero with binding UID = {selectedHeroUid}");
                await _socket.Send(new StatsEquipHeroResponse(EGatewayErrorCode.UnknownError, equipHeroSuccess));
                return;
            }

            _dataContext.Heroes.SelectedHeroUid = selectedHeroUid;
            await _socket.Send(new StatsEquipHeroResponse(EGatewayErrorCode.Success, equipHeroSuccess));
        }
    }
}