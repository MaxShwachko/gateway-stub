using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;

namespace GatewayStub.Api.RequestHandlers.Contract.ListeriaStorage
{
    public class HeroesGiveFreeExperienceToHeroHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.ListeriaStorage;
        public byte MethodId => (byte) EMethodId.HeroesGiveFreeExperienceToHero;

        private readonly IWebSocketWrapper _socket;

        public HeroesGiveFreeExperienceToHeroHandler(IWebSocketWrapper socket)
        {
            _socket = socket;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("HeroesGiveFreeExperienceToHero message received");
            await _socket.Send(new HeroesGiveFreeExperienceToHeroResponse(EGatewayErrorCode.Success));
        }
    }
}