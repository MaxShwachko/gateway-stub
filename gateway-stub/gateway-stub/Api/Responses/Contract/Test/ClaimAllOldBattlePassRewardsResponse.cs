using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
	public class ClaimAllOldBattlePassRewardsResponse : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.Test;
		public override byte MethodId => (byte) EMethodId.ClaimAllOldBattlePassRewards;

		public readonly EGatewayErrorCode ErrorCode;
		public readonly NetList<BattlePassRewardDto> Rewards;

		public ClaimAllOldBattlePassRewardsResponse(EGatewayErrorCode errorCode, NetList<BattlePassRewardDto> rewards)
		{
			ErrorCode = errorCode;
			Rewards = rewards;
		}

		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
			Rewards.NetSerialize(writer);
		}
	}
}