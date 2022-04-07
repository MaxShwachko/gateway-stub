using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Test;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Test
{
	public class ItemLevelUpDataReader : IContractRequestDataReader
	{
		public byte AgentId => (byte) EAgentId.Test;
		public byte MethodId => (byte) EMethodId.ItemLevelUp;

		public IContractRequestData ReadRequest(ByteReader reader)
		{
			var heroId = reader.ReadInt32();

			return new ItemLevelUpRequest(heroId);
		}
	}
}