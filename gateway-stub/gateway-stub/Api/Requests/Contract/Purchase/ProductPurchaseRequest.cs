using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Purchase
{
    public class ProductPurchaseRequest : IContractRequestData
    {
        public readonly string ProductType;

        public ProductPurchaseRequest(string productType)
        {
            ProductType = productType;
        }
    }
}