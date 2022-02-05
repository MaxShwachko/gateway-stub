using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
    public class GetScrollsHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Test;
        public byte MethodId => (byte) EMethodId.GetScrolls;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public GetScrollsHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("GetScrolls message received");
            var scrollsAmount = _dataContext.Heroes.ScrollsAmount;
            await _socket.Send(new GetScrollsResponse(EGatewayErrorCode.Success, scrollsAmount));
        }
    }
}