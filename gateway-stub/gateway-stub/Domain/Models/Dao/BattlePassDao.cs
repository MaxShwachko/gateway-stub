using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;

namespace GatewayStub.Domain.Models.Dao
{
	public class BattlePassDao
	{
		public BattlePassProgressionDto Progression;
        public NetList<UserBattlePassRewardDto> UserRewards;
		public NetList<BattlePassRewardDto> OldRewards;
		public BattlePassPricesDto Prices;
		public BattlePassSeasonDto CurrentSeason;
	}
}