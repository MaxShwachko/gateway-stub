using System;
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
            _dataContext.Heroes.SelectedHero = equipHeroRequest.BindingUid;
            var equipHeroSuccess = _dataContext.Heroes.EquipHeroSuccess;

            await _socket.Send(new StatsEquipHeroResponse(EGatewayErrorCode.Success, equipHeroSuccess));
        }
    }
}