using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Responses.Contract.Lobby;
using GatewayStub.Api.Responses.Contract.Purchase;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Data;

namespace GatewayStub.Api.RequestHandlers.Contract.Purchase
{
    public class WalletGetByUserIdHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.Purchase;
        public byte MethodId => (byte) EMethodId.WalletGetByUserId;
                
        private readonly IWebSocketWrapper _socket;
        private readonly IDataContext _dataContext;

        public WalletGetByUserIdHandler(IWebSocketWrapper socket, IDataContext dataContext)
        {
            _socket = socket;
            _dataContext = dataContext;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("WalletGetByUserId message received");
            var walletAddress = _dataContext.Blockchain.WalletAddress;
            await _socket.Send(new WalletGetByUserIdResponse(EGatewayErrorCode.Success, walletAddress));
        }
    }
}