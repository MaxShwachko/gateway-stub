using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Lobby;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Lobby
{
    public class RegionsSetDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.RegionsSet;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var regionName = reader.ReadString();
            var isFixed = reader.ReadBoolean();

            return new RegionsSetRequest(regionName, isFixed);
        }
    }
}