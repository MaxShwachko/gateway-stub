using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Auth;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Auth
{
    public class AuthAssignProviderAccountToDeviceIdHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthAssignProviderAccountToDeviceId;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public AuthAssignProviderAccountToDeviceIdHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("AuthAssignProviderAccountToDeviceId message received");
            var assignProviderAccountToDeviceIdSuccess = _dataContext.Auth.AssignProviderAccountToDeviceIdSuccess;
            await _socket.Send(new AuthAssignProviderAccountToDeviceIdResponse(EGatewayErrorCode.Success, assignProviderAccountToDeviceIdSuccess));
        }
    }
}