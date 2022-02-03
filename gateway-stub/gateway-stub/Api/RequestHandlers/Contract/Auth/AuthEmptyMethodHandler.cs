using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Auth;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Auth
{
    public class AuthEmptyMethodHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthEmptyMethod;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public AuthEmptyMethodHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("AuthEmptyMethod message received");
            var emptyMethodSuccess = _dataContext.Auth.EmptyMethodSuccess;
            await _socket.Send(new AuthEmptyMethodResponse(EGatewayErrorCode.Success, emptyMethodSuccess));
        }
    }
}