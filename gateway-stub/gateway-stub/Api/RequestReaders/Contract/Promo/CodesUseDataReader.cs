using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Promo;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Promo
{
    public class CodesUseDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Promo;
        public byte MethodId => (byte) EMethodId.CodesUse;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var code = reader.ReadString();

            return new CodesUseRequest(code);
        }
    }
}