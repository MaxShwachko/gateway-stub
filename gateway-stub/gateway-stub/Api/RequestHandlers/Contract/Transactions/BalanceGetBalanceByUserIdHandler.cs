using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Api.Responses.Contract.Transactions;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Transactions
{
    public class BalanceGetBalanceByUserIdHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Transactions;
        public byte MethodId => (byte) EMethodId.BalanceGetBalanceByUserId;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public BalanceGetBalanceByUserIdHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("BalanceGetBalanceByUserId message received");
            var balanceAmount = _dataContext.Balance.BalanceAmount;
            await _socket.Send(new BalanceGetBalanceByUserIdResponse(EGatewayErrorCode.Success, balanceAmount));
        }
    }
}