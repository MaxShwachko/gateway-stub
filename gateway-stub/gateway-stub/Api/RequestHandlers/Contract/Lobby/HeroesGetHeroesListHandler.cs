using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class HeroesGetHeroesListHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.HeroesGetHeroesList;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public HeroesGetHeroesListHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("HeroesGetHeroesList message received");
            var allHeroes = _dataContext.Heroes.AllHeroes;
            await _socket.Send(new HeroesGetHeroesListResponse(EGatewayErrorCode.Success, allHeroes));
        }
    }
}