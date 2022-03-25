using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.ListeriaStorage;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.ListeriaStorage
{
    public class HeroesGetHeroesListByUserIdHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.ListeriaStorage;
        public byte MethodId => (byte) EMethodId.HeroesGetHeroesListByUserId;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public HeroesGetHeroesListByUserIdHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("HeroesGetHeroesListByUserId message received");
            var availableHeroes = _dataContext.Heroes.AvailableHeroes;
            await _socket.Send(new HeroesGetHeroesListByUserIdResponse(EGatewayErrorCode.Success, availableHeroes));
        }
    }
}