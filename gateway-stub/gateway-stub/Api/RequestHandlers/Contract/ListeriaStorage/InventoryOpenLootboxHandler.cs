using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.Api.Responses.Contract.ListeriaStorage;
using GatewayStub.Api.Responses.Contract.ProductFactory;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;

namespace GatewayStub.Api.RequestHandlers.Contract.ListeriaStorage
{
    public class InventoryOpenLootboxHandler : IContractRequestHandler
    {
        public byte AgentId => (byte) EAgentId.ListeriaStorage;
        public byte MethodId => (byte) EMethodId.InventoryOpenLootbox;

        private readonly IWebSocketWrapper _socket;

        public InventoryOpenLootboxHandler(IWebSocketWrapper socket)
        {
            _socket = socket;
        }

        public async Task Handle(IContractRequestData request)
        {
            Console.WriteLine("InventoryOpenLootbox message received");
            await _socket.Send(new InventoryOpenLootboxResponse(EGatewayErrorCode.Success));
            await _socket.Send(new ProductLootboxOpenedNotification(EGatewayErrorCode.Success, new NetList<ItemDto>()));	// TODO : add lootbox rewards to data context from stage
        }
    }
}