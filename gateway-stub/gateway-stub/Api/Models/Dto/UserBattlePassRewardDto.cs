using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Models.Dto
{
	public class UserBattlePassRewardDto : INetSerialize
	{
		public int RewardId;
		public int RewardBindingId;
		public EBattlePassRewardState State;

		public void NetSerialize(ByteWriter writer)
		{
			writer.Write(RewardId);
			writer.Write(RewardBindingId);
			writer.Write((int) State);
		}

		public void NetDeserialize(ByteReader reader)
		{
			RewardId = reader.ReadInt32();
			RewardBindingId = reader.ReadInt32();
			State = (EBattlePassRewardState) reader.ReadInt32();
		}
	}
}