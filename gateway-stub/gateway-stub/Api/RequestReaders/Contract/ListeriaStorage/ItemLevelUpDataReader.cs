using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.ListeriaStorage;
using GatewayStub.Api.Requests.Contract.Test;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.ListeriaStorage
{
	public class ItemLevelUpDataReader : IContractRequestDataReader
	{
		public byte AgentId => (byte) EAgentId.ListeriaStorage;
		public byte MethodId => (byte) EMethodId.InventoryEndpointsLevelUp;

		public IContractRequestData ReadRequest(ByteReader reader)
		{
			var heroId = reader.ReadInt32();

			return new ItemLevelUpRequest(heroId);
		}
	}
}