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
        public readonly int ItemId;
        public readonly int BindingUid;
		public readonly EProductType Type;
        
        public InventoryAddedUnequippableItemNotification(EGatewayErrorCode errorCode, int itemId, int bindingUid, EProductType type)
        {
            ErrorCode = errorCode;
            ItemId = itemId;
            BindingUid = bindingUid;
			Type = type;
        }
        
        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(ItemId);
            writer.Write(BindingUid);
			writer.Write((int) Type);
        }
    }
}