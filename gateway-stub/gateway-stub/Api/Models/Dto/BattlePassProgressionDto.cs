using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
	public class BattlePassProgressionDto : INetSerialize
	{
		public NetList<BattlePassLevelDto> Levels;
		public int FinalRewardExperienceInterval;

		public void NetSerialize(ByteWriter writer)
		{
			Levels.NetSerialize(writer);
			writer.Write(FinalRewardExperienceInterval);
		}

		public void NetDeserialize(ByteReader reader)
		{
			Levels = DTOSerializer.NetDeserialize<NetList<BattlePassLevelDto>>(reader);
			FinalRewardExperienceInterval = reader.ReadInt32();
		}
	}
}