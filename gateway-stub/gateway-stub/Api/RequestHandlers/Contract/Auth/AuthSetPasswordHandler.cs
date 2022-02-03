using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Auth;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Auth
{
    public class AuthSetPasswordHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthSetPassword;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public AuthSetPasswordHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("AuthSetPassword message received");
            var session = _dataContext.Auth.Session;
            await _socket.Send(
                new AuthSetPasswordResponse(EGatewayErrorCode.Success, session.AccessToken, session.ExpiresIn,
                    session.IdToken, session.RefreshExpiresIn, session.RefreshToken, session.Scope,
                    session.SessionState, session.TokenType));
        }
    }
}