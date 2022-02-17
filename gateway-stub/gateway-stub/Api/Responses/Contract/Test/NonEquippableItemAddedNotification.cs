using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Responses.Contract.Test
{
    public class NonEquippableItemAddedNotification : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Test;
        public override byte MethodId => (byte) EMethodId.NonEquippableItemAddedNotification;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly ENonEquippableItemType Type;
        public readonly int ItemId;
        public readonly int BindingUid;
        
        public NonEquippableItemAddedNotification(EGatewayErrorCode errorCode, ENonEquippableItemType type, int itemId, int bindingUid)
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