using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Test;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Test
{
    public class OpenLootboxDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Test;
        public byte MethodId => (byte) EMethodId.OpenLootbox;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var uid = reader.ReadInt32();
            return new OpenLootboxRequest(uid);
        }
    }
}