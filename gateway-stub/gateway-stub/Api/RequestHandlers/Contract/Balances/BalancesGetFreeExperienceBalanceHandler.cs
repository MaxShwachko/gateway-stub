using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Balances;
using GatewayStub.Api.Responses.Contract.Test;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Balances
{
    public class BalancesGetFreeExperienceBalanceHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Balances;
        public byte MethodId => (byte) EMethodId.BalancesGetFreeExperienceBalance;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public BalancesGetFreeExperienceBalanceHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("BalancesGetFreeExperienceBalance message received");
            var undistributedExperience = _dataContext.Heroes.UndistributedExperience;
            await _socket.Send(new BalancesGetFreeExperienceBalanceResponse(EGatewayErrorCode.Success, undistributedExperience));
        }
    }
}