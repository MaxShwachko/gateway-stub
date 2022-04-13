using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
	public class BattlePassLevelDto : INetSerialize
	{
		public int Level;
		public int Experience;
		public NetList<BattlePassRewardDto> RewardsList;

		public void NetSerialize(ByteWriter writer)
		{
			writer.Write(Level);
			writer.Write(Experience);
			RewardsList.NetSerialize(writer);
		}

		public void NetDeserialize(ByteReader reader)
		{
			Level = reader.ReadInt32();
			Experience = reader.ReadInt32();
			RewardsList = DTOSerializer.NetDeserialize<NetList<BattlePassRewardDto>>(reader);
		}
	}
}