using GatewayStub.Api.Enums;
using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests
{
    public class ContractRequest : IRequest
    {
        public byte GetHeader() => (byte) EHeader.Contract;

        public readonly long Id;
        public readonly byte AgentId;
        public readonly byte MethodId;
        public readonly IContractRequestData Data;

        public ContractRequest(long id, byte agentId, byte methodId, IContractRequestData data)
        {
            Id = id;
            AgentId = agentId;
            MethodId = methodId;
            Data = data;
        }
    }
}