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
    public class AuthDeleteEmailRequestHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthDeleteEmailRequest;
        
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public AuthDeleteEmailRequestHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }
        
        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("AuthDeleteEmailRequest message received");
            var deleteEmailSuccess = _dataContext.Auth.AuthDeleteEmailSuccess;
            await _socket.Send(new AuthDeleteEmailResponse(EGatewayErrorCode.Success, deleteEmailSuccess));
        }
    }
}