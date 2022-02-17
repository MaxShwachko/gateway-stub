using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Purchase;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Purchase
{
    public class ProductGetHeroListDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Purchase;
        public byte MethodId => (byte) EMethodId.ProductGetHeroList;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            return new ProductGetHeroListRequest();
        }
    }
}