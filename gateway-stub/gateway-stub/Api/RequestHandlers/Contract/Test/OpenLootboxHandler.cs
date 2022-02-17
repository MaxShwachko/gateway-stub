using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
    public class OpenLootboxHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Test;
        public byte MethodId => (byte) EMethodId.OpenLootbox;

        private readonly IWebSocketWrapper _socket;

        public OpenLootboxHandler(IWebSocketWrapper socket)
        {
            _socket = socket;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("OpenLootbox message received");
            await _socket.Send(new OpenLootboxResponse(EGatewayErrorCode.Success));
        }
    }
}