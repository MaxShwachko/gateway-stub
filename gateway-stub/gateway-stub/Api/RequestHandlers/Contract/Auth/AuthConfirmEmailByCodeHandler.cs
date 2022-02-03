using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Auth;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Auth
{
    public class AuthConfirmEmailByCodeHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthConfirmEmailByCode;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public AuthConfirmEmailByCodeHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("ConfirmEmailByCode message received");
            var passwordHash = _dataContext.Auth.PasswordHash;
            await _socket.Send(new AuthConfirmEmailByCodeResponse(EGatewayErrorCode.Success, passwordHash));
        }
    }
}