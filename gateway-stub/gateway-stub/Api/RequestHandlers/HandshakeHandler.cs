using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests;
using GatewayStub.Api.Responses;
using GatewayStub.Core;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers
{
    public class HandshakeHandler : IRequestHandler
    {
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public byte Header => (byte) EHeader.Handshake;

        public HandshakeHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IRequest request)
        {
            var handshakeRequest = (HandshakeRequest) request;
            Console.WriteLine($"Handshake received. Incoming data: AuthToken: {handshakeRequest.AuthToken}, ApiVersion: {handshakeRequest.ApiVersion}, SessionToken: {handshakeRequest.SessionToken}");
            var userId = _dataContext.Matchmaking.UserId;
            await _socket.Send(new HandshakeResponse(true, userId, string.Empty, null));
        }
    }
}