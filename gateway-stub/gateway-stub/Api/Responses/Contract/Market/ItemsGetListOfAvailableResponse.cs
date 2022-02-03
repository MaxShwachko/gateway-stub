using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Market
{
    public class ItemsGetListOfAvailableResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Market;
        public override byte MethodId => (byte) EMethodId.ItemsGetListOfAvailable;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<EquipmentPurchaseDto> Products;

        public ItemsGetListOfAvailableResponse(EGatewayErrorCode errorCode, NetList<EquipmentPurchaseDto> products)
        {
            ErrorCode = errorCode;
            Products = products;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            Products.NetSerialize(writer);
        }
    }
}