using GatewayStub.ByteFormatter;

namespace GatewayStub.Core.Exchange
{
    public interface IContractRequestDataReader
    {
        byte AgentId { get; }
        byte MethodId { get; }

        IContractRequestData ReadRequest(ByteReader reader);
    }
}