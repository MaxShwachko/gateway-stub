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
    public class BalanceGetListWithPaginationHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Transactions;
        public byte MethodId => (byte) EMethodId.BalanceGetListWithPagination;

        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public BalanceGetListWithPaginationHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("BalanceGetListWithPagination message received");
            var balance = _dataContext.Balance;
            await _socket.Send(
                new BalanceGetListWithPaginationResponse(EGatewayErrorCode.Success, balance.TransactionsCurrentPage,
                    balance.TransactionsPages, balance.Transactions));
        }
    }
}