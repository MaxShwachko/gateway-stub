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
    public class HandshakeHandler : IRequestHandler
    {
        private readonly IWebSocketWrapper _socket;

        public byte Header => (byte) EHeader.Handshake;

        public HandshakeHandler(IWebSocketWrapper socket)
        {
            _socket = socket;
        }

        public async Task Handle(IRequest request)
        {
            var handshakeRequest = (HandshakeRequest) request;
            Console.WriteLine($"Handshake received. Incoming data: AuthToken: {handshakeRequest.AuthToken}, ApiVersion: {handshakeRequest.ApiVersion}, SessionToken: {handshakeRequest.SessionToken}");
            await _socket.Send(new HandshakeResponse(true, "TestUserId", string.Empty, null));
        }
    }
}