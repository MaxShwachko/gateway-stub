using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
	public class BattlePassProgressionDto : INetSerialize
	{
		public NetList<BattlePassLevelDto> Levels;
		public int FinalRewardExperienceInterval;
		public BattlePassRewardDto FinalReward;

		public void NetSerialize(ByteWriter writer)
		{
			Levels.NetSerialize(writer);
			writer.Write(FinalRewardExperienceInterval);
			FinalReward.NetSerialize(writer);
		}

		public void NetDeserialize(ByteReader reader)
		{
			Levels = DTOSerializer.NetDeserialize<NetList<BattlePassLevelDto>>(reader);
			FinalRewardExperienceInterval = reader.ReadInt32();
			FinalReward = DTOSerializer.NetDeserialize<BattlePassRewardDto>(reader);
		}
	}
}