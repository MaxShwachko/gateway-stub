using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Api.Responses.Contract.Promo;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Promo
{
    public class CodesUseHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Promo;
        public byte MethodId => (byte) EMethodId.CodesUse;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public CodesUseHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("CodesUse message received");
            var promoCodeRewards = _dataContext.Products.PromoCodeRewards;
            await _socket.Send(new CodesUseResponse(EGatewayErrorCode.Success, promoCodeRewards));
        }
    }
}