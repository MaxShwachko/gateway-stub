using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class InventoryAddedUnequippableItemNotification : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.InventoryAddedUnequippableItemNotification;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly ENonEquippableItemType Type;
        public readonly int ItemId;
        public readonly int BindingUid;
        
        public InventoryAddedUnequippableItemNotification(EGatewayErrorCode errorCode, ENonEquippableItemType type, int itemId, int bindingUid)
        {
            ErrorCode = errorCode;
            Type = type;
            ItemId = itemId;
            BindingUid = bindingUid;
        }
        
        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write((int) Type);
            writer.Write(ItemId);
            writer.Write(BindingUid);
        }
    }
}