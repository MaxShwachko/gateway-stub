using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Models.Dto
{
	public class BattlePassSeasonDto : INetSerialize
	{
		public int SeasonId;
		public EBattlePassSeasonState State;
		public bool HasUnclaimedOldRewards;
		public long StateUpdateDate;

		public void NetSerialize(ByteWriter writer)
		{
			writer.Write(SeasonId);
			writer.Write((int) State);
			writer.Write(HasUnclaimedOldRewards);
			writer.Write(StateUpdateDate);
		}

		public void NetDeserialize(ByteReader reader)
		{
			SeasonId = reader.ReadInt32();
			State = (EBattlePassSeasonState) reader.ReadInt32();
			HasUnclaimedOldRewards = reader.ReadBoolean();
			StateUpdateDate = reader.ReadInt64();
		}
	}
}