using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests;
using GatewayStub.Api.Responses;
using GatewayStub.Core;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;

namespace GatewayStub.Api.RequestHandlers
{
    public class PingPongHandler : IRequestHandler
    {
        private readonly IWebSocketWrapper _socket;

        public byte Header => (byte) EHeader.PingPong;

        public PingPongHandler(IWebSocketWrapper socket)
        {
            _socket = socket;
        }

        public async Task Handle(IRequest request)
        {
            Console.WriteLine("Ping received");
            await _socket.Send(new PingPongResponse());
        }
    }
}