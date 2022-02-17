using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
    public class GetAllHeroesListHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Test;
        public byte MethodId => (byte) EMethodId.GetAllHeroesList;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public GetAllHeroesListHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("GetAllHeroesList message received");
            var allHeroes = _dataContext.Heroes.AllHeroes;
            await _socket.Send(new GetAllHeroesListResponse(EGatewayErrorCode.Success, allHeroes));
        }
    }
}