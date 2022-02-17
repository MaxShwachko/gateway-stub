using GatewayStub.ByteFormatter;

namespace GatewayStub.Core.Exchange
{
    public interface IContractRequestDataReader
    {
        public byte AgentId { get; }
        public byte MethodId { get; }

        IContractRequestData ReadRequest(ByteReader reader);
    }
}