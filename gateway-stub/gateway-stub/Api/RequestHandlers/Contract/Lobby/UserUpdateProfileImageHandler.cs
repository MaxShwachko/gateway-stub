using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class UserUpdateProfileImageHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.UserUpdateProfileImage;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public UserUpdateProfileImageHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("UserUpdateProfileImage message received");
            var user = _dataContext.User;
            await _socket.Send(new UserUpdateProfileImageResponse(EGatewayErrorCode.Success, user.SetImageSuccess, user.Image));
        }
    }
}