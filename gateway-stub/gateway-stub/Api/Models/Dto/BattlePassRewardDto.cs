using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Models.Dto
{
	public class BattlePassRewardDto : INetSerialize
	{
		public int RewardId;
		public EBattlePassType BattlePassType;
		public ItemDto ItemReward;

		public void NetSerialize(ByteWriter writer)
		{
			writer.Write(RewardId);
			writer.Write((int) BattlePassType);
			ItemReward.NetSerialize(writer);
		}

		public void NetDeserialize(ByteReader reader)
		{
			RewardId = reader.ReadInt32();
			BattlePassType = (EBattlePassType) reader.ReadInt32();
			ItemReward = DTOSerializer.NetDeserialize<ItemDto>(reader);
		}
	}
}