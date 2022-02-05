using System;
using System.Linq;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Test;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
    public class LevelupHeroHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Test;
        public byte MethodId => (byte) EMethodId.LevelupHero;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public LevelupHeroHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("SpendExperience message received");
            var heroDto = _dataContext.Heroes.AvailableHeroes.FirstOrDefault();
            await _socket.Send(new LevelupHeroResponse(EGatewayErrorCode.Success, heroDto));
        }
    }
}