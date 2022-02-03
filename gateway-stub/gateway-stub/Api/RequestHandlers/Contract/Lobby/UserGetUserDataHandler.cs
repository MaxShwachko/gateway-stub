using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class UserGetUserDataHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.UserGetUserData;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public UserGetUserDataHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("UserGetUserData message received");
            var regions = _dataContext.User;
            await _socket.Send(new UserGetUserDataResponse(EGatewayErrorCode.Success, regions.Username, regions.Rating,
                regions.IncreaseBy, regions.DecreaseBy, regions.Draw, regions.PlaceInLeaderBoard, regions.Image,
                regions.Email, regions.TokensIncreaseBy));
        }
    }
}