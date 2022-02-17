using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;
using GatewayStub.Domain.Services;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class LobbyStartGameHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.LobbyStartGame;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;
        private readonly IMatchmakingService _matchmakingService;

        public LobbyStartGameHandler(IWebSocketWrapper socket, IDataContext dataContext, IMatchmakingService matchmakingService)
        {
            _socket = socket;
            _dataContext = dataContext;
            _matchmakingService = matchmakingService;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("LobbyStartGame message received");
            var startSearchingSuccess = _dataContext.Matchmaking.StartSearchingSuccess;
            await _matchmakingService.StartMatchmaking();
            await _socket.Send(new LobbyStartGameResponse(EGatewayErrorCode.Success, startSearchingSuccess));
        }
    }
}