using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Auth;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Auth
{
    public class AuthLoginHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthLogin;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public AuthLoginHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("AuthLogin message received");
            var login = _dataContext.Auth.Session;
            await _socket.Send(
                new AuthLoginResponse(EGatewayErrorCode.Success, login.AccessToken, login.ExpiresIn,
                    login.RefreshExpiresIn, login.RefreshToken, login.TokenType, login.NotBeforePolicy,
                    login.SessionState, login.Scope, login.UserId));
        }
    }
}