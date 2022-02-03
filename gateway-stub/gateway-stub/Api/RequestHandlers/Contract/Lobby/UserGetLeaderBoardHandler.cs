using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class UserGetLeaderBoardHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.UserGetLeaderBoard;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public UserGetLeaderBoardHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("UserGetLeaderBoard message received");
            var regions = _dataContext.Leaderboard;
            await _socket.Send(new UserGetLeaderBoardResponse(
                EGatewayErrorCode.Success, regions.CurrentPage, regions.Pages, regions.Leaderboard));
        }
    }
}