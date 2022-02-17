using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
    public class GetLootboxProductsHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Test;
        public byte MethodId => (byte) EMethodId.GetLootboxProducts;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public GetLootboxProductsHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("GetLootboxProducts message received");
            var lootboxProducts = _dataContext.Lootboxes.LootboxProducts;
            await _socket.Send(new GetLootboxProductsResponse(EGatewayErrorCode.Success, lootboxProducts));
        }
    }
}