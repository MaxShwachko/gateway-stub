using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Purchase;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Purchase
{
    public class ProductPurchaseDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Purchase;
        public byte MethodId => (byte) EMethodId.ProductPurchase;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var type = reader.ReadString();

            return new ProductPurchaseRequest(type);
        }
    }
}