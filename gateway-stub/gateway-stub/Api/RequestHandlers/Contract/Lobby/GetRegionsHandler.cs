using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Lobby
{
    public class GetRegionsHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.GetRegions;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public GetRegionsHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("GetRegions message received");
            var regions = _dataContext.Regions;
            await _socket.Send(new GetRegionsResponse(EGatewayErrorCode.Success, regions.ActiveRegion, regions.IsFixed, regions.Regions));
        }
    }
}