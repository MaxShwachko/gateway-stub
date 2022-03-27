using System;
using System.Linq;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.ListeriaStorage;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.ListeriaStorage
{
    public class LevelupHeroHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.ListeriaStorage;
        public byte MethodId => (byte) EMethodId.HeroesLevelUp;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public LevelupHeroHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("HeroesLevelUp message received");
            var heroDto = _dataContext.Heroes.AvailableHeroes.FirstOrDefault();
            await _socket.Send(new HeroesLevelUpResponse(EGatewayErrorCode.Success, heroDto));
        }
    }
}