using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Api.Responses.Contract.Purchase;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Purchase
{
    public class ProductGetHeroListHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Purchase;
        public byte MethodId => (byte) EMethodId.ProductGetHeroList;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public ProductGetHeroListHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("ProductGetHeroList message received");
            var heroProducts = _dataContext.Products.HeroProducts;
            await _socket.Send(new ProductGetHeroListResponse(EGatewayErrorCode.Success, heroProducts));
        }
    }
}