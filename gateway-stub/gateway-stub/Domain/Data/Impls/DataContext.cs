using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Domain.Enums;
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
                    new EquipmentPurchaseDto
                    {
                        EquipmentItemId = 3,
                        ProductType = "Item: 3",
                        CurrencyType = "LIS",
                        Price = "2",
                        Effects = new NetList<EquipmentEffectDto>
                        {
                            new EquipmentEffectDto
                            {
                                StatToEffect = EHeroStatType.Agility,
                                Power = "15"
                            },
                            new EquipmentEffectDto
                            {
                                StatToEffect = EHeroStatType.MoveSpeed,
                                Power = "1"
                            }
                        },
                        IsSold = false,
                    },
                    new EquipmentPurchaseDto
                    {
                        EquipmentItemId = 2,
                        ProductType = "Item: 2",
                        CurrencyType = "LIS",
                        Price = "5",
                        Effects = new NetList<EquipmentEffectDto>
                        {
                            new EquipmentEffectDto
                            {
                                StatToEffect = EHeroStatType.Health,
                                Power = "150"
                            },
                            new EquipmentEffectDto
                            {
                                StatToEffect = EHeroStatType.Strength,
                                Power = "10"
                            }
                        },
                        IsSold = true,
                    }
                },
                PromoCodeRewards = new NetList<PromoRewardDto>
                {
                },
                HeroProducts = new NetList<HeroPurchaseDto>
                {
                    new HeroPurchaseDto
                    {
                        HeroId = 1,
                        ProductType = "Hero: 1",
                        CurrencyType = "LIS",
                        Price = "15",
                        HeroStats = new HeroStatsDto
                        {
                            Strength = 1,
                            Agility = 1,
                            Intelligence = 1,
                            MainStat = EMainStat.Agility,
                            Health = 100,
                            HealthRegenPercent = "1",
                            Armor = "1",
                            MoveSpeed = "1",
                            AttackDamage = 1,
                            AttackReloadSpeed = "1",
                            SkillPower = 1,
                            SkillEffectPower = 1,
                            UltPower = 1,
                            UltEffectPower = 1,
                            VampirismPower = "1",
                        },
                    },
                    new HeroPurchaseDto
                    {
                        HeroId = 3,
                        ProductType = "Hero: 3",
                        CurrencyType = "LIS",
                        Price = "15",
                        HeroStats = new HeroStatsDto
                        {
                            Strength = 1,
                            Agility = 1,
                            Intelligence = 1,
                            MainStat = EMainStat.Agility,
                            Health = 100,
                            HealthRegenPercent = "1",
                            Armor = "1",
                            MoveSpeed = "1",
                            AttackDamage = 1,
                            AttackReloadSpeed = "1",
                            SkillPower = 1,
                            SkillEffectPower = 1,
                            UltPower = 1,
                            UltEffectPower = 1,
                            VampirismPower = "1",
                        },
                    }
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
                    new BalanceDto
                    {
                        Key = "LIS",
                        Amount = "100",
                    }
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