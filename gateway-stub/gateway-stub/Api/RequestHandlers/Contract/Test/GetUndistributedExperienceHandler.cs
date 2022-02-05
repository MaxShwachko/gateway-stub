using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Test
{
    public class GetUndistributedExperienceHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Test;
        public byte MethodId => (byte) EMethodId.GetUndistributedExperience;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public GetUndistributedExperienceHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("GetUndistributedExperience message received");
            var undistributedExperience = _dataContext.Heroes.UndistributedExperience;
            await _socket.Send(new GetUndistributedExperienceResponse(EGatewayErrorCode.Success, undistributedExperience));
        }
    }
}