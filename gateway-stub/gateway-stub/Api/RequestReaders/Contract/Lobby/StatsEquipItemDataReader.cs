using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Lobby;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Lobby
{
    public class StatsEquipItemDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Lobby;
        public byte MethodId => (byte) EMethodId.StatsEquipItem;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var bindingUid = reader.ReadInt32();
            var slotUid = reader.ReadInt32();
            var heroUid = reader.ReadInt32();

            return new StatsEquipItemRequest(bindingUid, slotUid, heroUid);
        }
    }
}