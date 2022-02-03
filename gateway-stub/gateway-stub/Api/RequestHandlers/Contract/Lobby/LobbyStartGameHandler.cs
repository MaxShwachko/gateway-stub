using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class LobbyStartGameHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.LobbyStartGame;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public LobbyStartGameHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("LobbyStartGame message received");
            var startSearchingSuccess = _dataContext.Matchmaking.StartSearchingSuccess;
            //TODO : start matchmaking flow here
            await _socket.Send(new LobbyStartGameResponse(EGatewayErrorCode.Success, startSearchingSuccess));
        }
    }
}