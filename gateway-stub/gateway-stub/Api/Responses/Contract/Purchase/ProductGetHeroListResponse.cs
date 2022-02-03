using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Purchase
{
    public class ProductGetHeroListResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Purchase;
        public override byte MethodId => (byte) EMethodId.ProductGetHeroList;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<HeroPurchaseDto> List;

        public ProductGetHeroListResponse(EGatewayErrorCode errorCode, NetList<HeroPurchaseDto> list)
        {
            ErrorCode = errorCode;
            List = list;
        }
        
        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            List.NetSerialize(writer);
        }
    }
}