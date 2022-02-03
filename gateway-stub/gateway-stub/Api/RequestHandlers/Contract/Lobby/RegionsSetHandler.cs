using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class RegionsSetHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.RegionsSet;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public RegionsSetHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("RegionsSet message received");
            var regionSetSuccess = _dataContext.Regions.RegionSetSuccess;
            await _socket.Send(new RegionsSetResponse(EGatewayErrorCode.Success, regionSetSuccess));
        }
    }
}