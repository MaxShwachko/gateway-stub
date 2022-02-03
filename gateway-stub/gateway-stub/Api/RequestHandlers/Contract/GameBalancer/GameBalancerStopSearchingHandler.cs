using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.GameBalancer;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.GameBalancer
{
    public class GameBalancerStopSearchingHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.GameBalancer;
        public byte MethodId => (byte) EMethodId.GameBalancerStopSearching;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public GameBalancerStopSearchingHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("GameBalancerStopSearching message received");
            var stopSearchingSuccess = _dataContext.Matchmaking.StopSearchingSuccess;
            await _socket.Send(new GameBalancerStopSearchingResponse(EGatewayErrorCode.Success, stopSearchingSuccess));
        }
    }
}