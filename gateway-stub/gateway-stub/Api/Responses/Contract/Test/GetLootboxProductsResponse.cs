using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
    public class GetLootboxProductsResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Test;
        public override byte MethodId => (byte) EMethodId.GetLootboxesList;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<LootboxProductDto> Products;
        
        public GetLootboxProductsResponse(EGatewayErrorCode errorCode, NetList<LootboxProductDto> products)
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