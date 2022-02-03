using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.GameBalancer;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.GameBalancer
{
    public class GameBalancerStopSearchingDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.GameBalancer;
        public byte MethodId => (byte) EMethodId.GameBalancerStopSearching;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            return new GameBalancerStopSearchingRequest();
        }
    }
}