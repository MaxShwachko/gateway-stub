using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
	public class ClaimBattlePassRewardResponse : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.Test;
		public override byte MethodId => (byte) EMethodId.ClaimBattlePassReward;

		public readonly EGatewayErrorCode ErrorCode;
		public readonly int RewardBindingId;

		public ClaimBattlePassRewardResponse(EGatewayErrorCode errorCode, int rewardBindingId)
		{
			ErrorCode = errorCode;
			RewardBindingId = rewardBindingId;
		}

		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
			writer.Write(RewardBindingId);
		}
	}
}