using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Purchase
{
    public class ProductPurchaseResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.NewPurchase;
        public override byte MethodId => (byte) EMethodId.ProductPurchaseLootbox;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly bool Success;

        public ProductPurchaseResponse(EGatewayErrorCode errorCode, bool success)
        {
            ErrorCode = errorCode;
            Success = success;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(Success);
        }
    }
}