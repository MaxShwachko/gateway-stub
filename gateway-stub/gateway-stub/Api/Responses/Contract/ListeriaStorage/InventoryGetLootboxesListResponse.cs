using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.ListeriaStorage
{
    public class InventoryGetLootboxesListResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.ListeriaStorage;
        public override byte MethodId => (byte) EMethodId.InventoryGetLootboxesList;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<LootboxDto> Lootboxes;

        public InventoryGetLootboxesListResponse(EGatewayErrorCode errorCode, NetList<LootboxDto> lootboxes)
        {
            ErrorCode = errorCode;
            Lootboxes = lootboxes;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            Lootboxes.NetSerialize(writer);
        }
    }
}