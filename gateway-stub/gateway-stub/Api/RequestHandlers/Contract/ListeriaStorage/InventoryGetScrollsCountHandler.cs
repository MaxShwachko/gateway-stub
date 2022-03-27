using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.ListeriaStorage;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.ListeriaStorage
{
    public class InventoryGetScrollsCountHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.ListeriaStorage;
        public byte MethodId => (byte) EMethodId.InventoryGetScrollsCount;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public InventoryGetScrollsCountHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("InventoryGetScrollsCount message received");
            var scrollsAmount = _dataContext.Heroes.ScrollsAmount;
            await _socket.Send(new InventoryGetScrollsCountResponse(EGatewayErrorCode.Success, scrollsAmount));
        }
    }
}