using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class InventoryGetItemsListResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.InventoryGetItemsList;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<EquipmentItemDto> Items;

        public InventoryGetItemsListResponse(EGatewayErrorCode errorCode, NetList<EquipmentItemDto> items)
        {
            ErrorCode = errorCode;
            Items = items;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            Items.NetSerialize(writer);
        }
    }
}