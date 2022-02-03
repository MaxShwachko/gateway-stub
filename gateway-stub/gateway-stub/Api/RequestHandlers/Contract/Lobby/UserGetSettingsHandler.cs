using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class UserGetSettingsHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.UserGetSettings;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public UserGetSettingsHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("UserGetSettings message received");
            var regions = _dataContext.Settings;
            await _socket.Send(new UserGetSettingsResponse(EGatewayErrorCode.Success, regions.Music, regions.Sounds,
                regions.Language, regions.Quality, regions.HfrEffects, regions.IsChanged));
        }
    }
}