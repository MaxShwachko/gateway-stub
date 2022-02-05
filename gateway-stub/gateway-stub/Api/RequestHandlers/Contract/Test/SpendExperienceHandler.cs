using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
    public class SpendExperienceHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Test;
        public byte MethodId => (byte) EMethodId.SpendExperience;

        private readonly IWebSocketWrapper _socket;

        public SpendExperienceHandler(IWebSocketWrapper socket)
        {
            _socket = socket;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("SpendExperience message received");
            await _socket.Send(new SpendExperienceResponse(EGatewayErrorCode.Success));
        }
    }
}