using GatewayStub.ByteFormatter;

namespace GatewayStub.Core.Exchange
{
    public interface IContractRequestReader
    {
        public byte AgentId { get; }
        public byte MethodId { get; }

        IContractRequestData ReadRequest(ByteReader reader);
    }
}