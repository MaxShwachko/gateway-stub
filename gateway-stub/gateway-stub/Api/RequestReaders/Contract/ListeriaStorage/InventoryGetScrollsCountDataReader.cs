using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.ListeriaStorage;
using GatewayStub.Api.Requests.Contract.Test;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.ListeriaStorage
{
    public class InventoryGetScrollsCountDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.ListeriaStorage;
        public byte MethodId => (byte) EMethodId.InventoryGetScrollsCount;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            return new InventoryGetScrollsCountRequest();
        }
    }
}