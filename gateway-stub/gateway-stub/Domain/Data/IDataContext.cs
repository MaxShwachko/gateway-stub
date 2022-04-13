using GatewayStub.Api.Models.Dto;
using GatewayStub.Domain.Models.Dao;

namespace GatewayStub.Domain.Data
{
    public interface IDataContext
    {
        RegionsDao Regions { get; }
        AuthDao Auth { get; }
        MatchmakingDao Matchmaking { get; set; }
        ProductsDao Products { get; set; }
        EquipmentDao Equipment { get; set; }
        BlockchainDao Blockchain { get; set; }
        BalanceDao Balance { get; set; }
        HeroesDao Heroes { get; set; }
        LeaderboardDao Leaderboard { get; set; }
        SettingsDao Settings { get; set; }
        UserDao User { get; set; }
        LootboxesDao Lootboxes { get; set; }
        BattlePassDao BattlePass { get; set; }
    }

}