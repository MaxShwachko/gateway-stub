using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Market
{
    public class ItemsGetLootboxesListResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Market;
        public override byte MethodId => (byte) EMethodId.ItemsGetLootboxesList;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<LootboxProductDto> Products;

        public ItemsGetLootboxesListResponse(EGatewayErrorCode errorCode, NetList<LootboxProductDto> products)
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