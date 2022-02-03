using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Domain.Models.Dao;

namespace GatewayStub.Domain.Data.Impls
{
    public class DataContext : IDataContext
    {
        public RegionsDao Regions { get; }
        public AuthDao Auth { get; }
        public MatchmakingDao Matchmaking { get; set; }
        public ProductsDao Products { get; set; }
        public EquipmentDao Equipment { get; set; }
        public BlockchainDao Blockchain { get; set; }
        public BalanceDao Balance { get; set; }
        public HeroesDao Heroes { get; set; }
        public LeaderboardDao Leaderboard { get; set; }
        public SettingsDao Settings { get; set; }
        public UserDao User { get; set; }

        public DataContext()
        {
            Regions = new RegionsDao
            {
                Regions = new NetList<RegionDto> {new RegionDto {Host = "https://www.google.com.ua/", Name = "Google"}},
                ActiveRegion = "Google",
                IsFixed = true,
                RegionSetSuccess = true
            };

            Auth = new AuthDao
            {
                AssignProviderAccountToDeviceIdSuccess = true,
                ConfirmPasswordSuccess = true,
                AuthDeleteEmailSuccess = true,
                EmptyMethodSuccess = true,
                LogoutSuccess = true,
                ResentConfirmationMailSuccess = true,
                ResetPasswordSuccess = true,
                SendRequestToResetPasswordSuccess = true,
                PasswordHash = "PasswordHash",
                EmailHash = "EmailHash",
                Session = new SessionDao
                {
                    AccessToken = "AccessToken",
                    ExpiresIn = 9999,
                    RefreshExpiresIn = 9999,
                    RefreshToken = "RefreshToken",
                    TokenType = "TokenType",
                    NotBeforePolicy = 1,
                    SessionState = "SessionState",
                    Scope = "Scope",
                    UserId = "UserId",
                    IdToken = "IdToken"
                }
            };

            Matchmaking = new MatchmakingDao
            {
                StopSearchingSuccess = true,
                StartSearchingSuccess = true,
            };

            Products = new ProductsDao
            {
                EquipmentProducts = new NetList<EquipmentPurchaseDto>
                {
                },
                PromoCodeRewards = new NetList<PromoRewardDto>
                {
                },
                HeroProducts = new NetList<HeroPurchaseDto>
                {
                },
                ProductPurchaseSuccess = true,
            };

            Equipment = new EquipmentDao
            {
                Equipment = new NetList<EquipmentItemDto>
                {
                },
                EquippedItemBindingUid = 1,
                EquippedItemSlotUid = 1,
                EquippedItemHeroUid = 1,
                EquipmentBonuses = new HeroStatsDto
                {
                }
            };

            Blockchain = new BlockchainDao
            {
                WalletAddress = "WalletAddress"
            };

            Balance = new BalanceDao
            {
                BalanceAmount = "100",
                Currencies = new NetList<BalanceDto>
                {
                },
                TransactionsCurrentPage = 1,
                TransactionsPages = 1,
                Transactions = new NetList<TransactionDto>
                {
                }
            };

            Heroes = new HeroesDao
            {
                AvailableHeroes = new NetList<HeroDto>
                {
                },
                EquipHeroSuccess = true
            };

            Leaderboard = new LeaderboardDao
            {
                CurrentPage = 1,
                Pages = 1,
                Leaderboard = new NetList<LeaderboardPlaceDto>
                {
                }
            };

            Settings = new SettingsDao
            {
                Music = true,
                Sounds = true,
                Language = 1,
                Quality = 1,
                HfrEffects = 1,
                IsChanged = true,
                SetSettingsSuccess = true,
            };

            User = new UserDao
            {
                Username = "Username",
                Rating = 1,
                IncreaseBy = 1,
                DecreaseBy = 1,
                Draw = 1,
                PlaceInLeaderBoard = 1,
                Image = 1,
                Email = "Email",
                TokensIncreaseBy = "1",
                SetImageSuccess = true,
                SetUsernameSuccess = true,
            };
        }
    }
}