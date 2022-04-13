using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Test
{
	public class ClaimBattlePassRewardRequest : IContractRequestData
	{
		public int RewardBindingId;

		public ClaimBattlePassRewardRequest(int rewardBindingId)
		{
			RewardBindingId = rewardBindingId;
		}
	}
}