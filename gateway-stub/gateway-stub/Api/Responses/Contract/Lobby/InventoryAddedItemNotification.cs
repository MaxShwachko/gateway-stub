using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class InventoryAddedItemNotification : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.InventoryAddedItemNotification;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly int EquipmentItemId;
        public readonly int BindingUid;
        public readonly string BlockId;
        public readonly string TransactionHash;
        public readonly string LinkToExplorer;
        public readonly NetList<EquipmentEffectDto> Effects;

        public InventoryAddedItemNotification(EGatewayErrorCode errorCode, int equipmentItemId, int bindingUid,
            string blockId, string transactionHash, string linkToExplorer, NetList<EquipmentEffectDto> effects)
        {
            ErrorCode = errorCode;
            EquipmentItemId = equipmentItemId;
            BindingUid = bindingUid;
            BlockId = blockId;
            TransactionHash = transactionHash;
            LinkToExplorer = linkToExplorer;
            Effects = effects;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(EquipmentItemId);
            writer.Write(BindingUid);
            writer.Write(BlockId);
            writer.Write(TransactionHash);
            writer.Write(LinkToExplorer);
            Effects.NetSerialize(writer);
        }
    }
}