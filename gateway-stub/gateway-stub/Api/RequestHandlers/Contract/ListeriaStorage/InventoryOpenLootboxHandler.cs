using System;
using System.Threading.Tasks;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.Api.Requests.Contract.ListeriaStorage;
using GatewayStub.Api.Responses.Contract.ListeriaStorage;
using GatewayStub.Api.Responses.Contract.ProductFactory;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.WebSocket;
using GatewayStub.Domain.Enums;

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
            var lootboxRequest = (InventoryOpenLootboxRequest)request;
            await _socket.Send(new InventoryOpenLootboxResponse(EGatewayErrorCode.Success));
            
            var scrolls = new ItemDto(EProductType.HeroScroll, 5, 0);
            var hero = new ItemDto(EProductType.Hero, 1, 3);
            var item = new ItemDto(EProductType.Equipment, 1, 5);
            var itemScroll= new ItemDto(EProductType.EquipmentScroll, 3, 0);
            var exp= new ItemDto(EProductType.UndistributedExperience, 170, 0);
            var rewards = new NetList<ItemDto>() { scrolls, hero, item, itemScroll, exp };
            
            await _socket.Send(new ProductLootboxOpenedNotification(EGatewayErrorCode.Success, rewards, lootboxRequest.BindingUid));	// TODO : add lootbox rewards to data context from stage
        }
    }
}