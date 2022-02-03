using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class InventoryGetItemsListHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.InventoryGetItemsList;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public InventoryGetItemsListHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("InventoryGetItemsList message received");
            var equipment = _dataContext.Equipment.Equipment;
            await _socket.Send(new InventoryGetItemsListResponse(EGatewayErrorCode.Success, equipment));
        }
    }
}