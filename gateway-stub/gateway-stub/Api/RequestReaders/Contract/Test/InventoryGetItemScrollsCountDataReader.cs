using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Test;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Test
{
	public class InventoryGetItemScrollsCountDataReader : IContractRequestDataReader
	{
		public byte AgentId => (byte) EAgentId.Test;
		public byte MethodId => (byte) EMethodId.InventoryGetItemScrollsCount;

		public IContractRequestData ReadRequest(ByteReader reader)
		{
			return new InventoryGetItemScrollsCountRequest();
		}
	}
}