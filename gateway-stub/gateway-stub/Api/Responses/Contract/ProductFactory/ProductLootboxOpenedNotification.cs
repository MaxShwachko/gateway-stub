using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.ProductFactory
{
    public class ProductLootboxOpenedNotification : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.ProductFactory;
        public override byte MethodId => (byte) EMethodId.ProductLootboxOpenedNotification;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<ItemDto> Rewards;
        public readonly int BindingUid;

        public ProductLootboxOpenedNotification(EGatewayErrorCode errorCode, NetList<ItemDto> rewards, int bindingUid)
        {
            ErrorCode = errorCode;
            Rewards = rewards;
            BindingUid = bindingUid;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            Rewards.NetSerialize(writer);
            writer.Write(BindingUid);
        }
    }
}