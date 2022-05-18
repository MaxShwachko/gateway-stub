using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Purchase;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Purchase
{
    public class ProductPurchaseHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.NewPurchase;
        public byte MethodId => (byte) EMethodId.ProductPurchaseLootbox;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public ProductPurchaseHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("ProductPurchase message received");
            var purchaseSuccess = _dataContext.Products.ProductPurchaseSuccess;
            await _socket.Send(new ProductPurchaseResponse(EGatewayErrorCode.Success, purchaseSuccess));
        }
    }
}