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
    public class AuthConfirmPasswordHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthConfirmPassword;
        
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public AuthConfirmPasswordHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }
        
        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("ConfirmPassword message received");
            var authConfirmPasswordSuccess = _dataContext.Auth.ConfirmPasswordSuccess;
            await _socket.Send(new AuthConfirmPasswordResponse(EGatewayErrorCode.Success, authConfirmPasswordSuccess));
        }
    }
}