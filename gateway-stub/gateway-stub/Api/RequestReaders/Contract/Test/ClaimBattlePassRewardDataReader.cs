using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Test;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Test
{
	public class ClaimBattlePassRewardDataReader : IContractRequestDataReader
	{
		public byte AgentId => (byte) EAgentId.Test;
		public byte MethodId => (byte) EMethodId.ClaimBattlePassReward;

		public IContractRequestData ReadRequest(ByteReader reader)
		{
			var bindingId = reader.ReadInt32();
			return new ClaimBattlePassRewardRequest(bindingId);
		}
	}
}