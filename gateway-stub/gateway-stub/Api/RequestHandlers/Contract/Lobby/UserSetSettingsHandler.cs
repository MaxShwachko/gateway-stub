using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class UserSetSettingsHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.UserSetSettings;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public UserSetSettingsHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("UserSetSettings message received");
            var setSettingsSuccess = _dataContext.Settings.SetSettingsSuccess;
            await _socket.Send(new UserSetSettingsResponse(EGatewayErrorCode.Success, setSettingsSuccess));
        }
    }
}