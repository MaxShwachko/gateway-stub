using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Lobby;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Lobby
{
    public class InventoryGetItemsListDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.ListeriaStorage;
        public byte MethodId => (byte) EMethodId.InventoryGetItemsList;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            return new InventoryGetItemsListRequest();
        }
    }
}