using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Test;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.RequestReaders.Contract.Test
{
	public class UpgradeBattlePassTypeDataReader : IContractRequestDataReader
	{
		public byte AgentId => (byte) EAgentId.Test;
		public byte MethodId => (byte) EMethodId.UpgradeBattlePassType;

		public IContractRequestData ReadRequest(ByteReader reader)
		{
			var type = (EBattlePassType) reader.ReadInt32();
			return new UpgradeBattlePassTypeRequest(type);
		}
	}
}