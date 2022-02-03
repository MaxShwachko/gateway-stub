using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class StatsUnequipItemHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.StatsUnequipItem;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public StatsUnequipItemHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("StatsUnequipItem message received");
            var equipment = _dataContext.Equipment;
            await _socket.Send(new StatsUnequipItemResponse(EGatewayErrorCode.Success, equipment.EquippedItemBindingUid,
                equipment.EquipmentBonuses));
        }
    }
}