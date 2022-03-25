using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Market;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Market
{
    public class ItemsGetLootboxesListHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Market;
        public byte MethodId => (byte) EMethodId.ItemsGetLootboxesList;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public ItemsGetLootboxesListHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("ItemsGetListOfAvailable message received");
            var equipmentProducts = _dataContext.Products.LootboxProducts;
            await _socket.Send(new ItemsGetLootboxesListResponse(EGatewayErrorCode.Success, equipmentProducts));
        }
    }
}