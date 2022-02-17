using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
    public class GetLootboxesListHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Test;
        public byte MethodId => (byte) EMethodId.GetLootboxesList;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public GetLootboxesListHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("GetLootboxesList message received");
            var userLootboxes = _dataContext.Lootboxes.UserLootboxes;
            await _socket.Send(new GetLootboxesListResponse(EGatewayErrorCode.Success, userLootboxes));
        }
    }
}