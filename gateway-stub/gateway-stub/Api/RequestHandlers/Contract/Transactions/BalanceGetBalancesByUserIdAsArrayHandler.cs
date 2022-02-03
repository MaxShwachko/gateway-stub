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
    public class BalanceGetBalancesByUserIdAsArrayHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Transactions;
        public byte MethodId => (byte) EMethodId.BalanceGetBalancesByUserIdAsArray;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public BalanceGetBalancesByUserIdAsArrayHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("BalanceGetBalancesByUserIdAsArray message received");
            var currencies = _dataContext.Balance.Currencies;
            await _socket.Send(new BalanceGetBalancesByUserIdAsArrayResponse(EGatewayErrorCode.Success, currencies));
        }
    }
}