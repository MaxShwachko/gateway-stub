using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.ListeriaStorage;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.ListeriaStorage
{
    public class InventoryGetLootboxesListHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.ListeriaStorage;
        public byte MethodId => (byte) EMethodId.InventoryGetLootboxesList;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public InventoryGetLootboxesListHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("InventoryGetLootboxesList message received");
            var userLootboxes = _dataContext.Lootboxes.UserLootboxes;
            await _socket.Send(new InventoryGetLootboxesListResponse(EGatewayErrorCode.Success, userLootboxes));
        }
    }
}