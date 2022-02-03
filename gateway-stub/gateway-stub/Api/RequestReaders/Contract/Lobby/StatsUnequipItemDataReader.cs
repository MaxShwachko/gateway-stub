using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Lobby;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Lobby
{
    public class StatsUnequipItemDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.StatsUnequipItem;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var bindingUid = reader.ReadInt32();
            var heroBindingId = reader.ReadInt32();

            return new StatsUnequipItemRequest(bindingUid, heroBindingId);
        }
    }
}