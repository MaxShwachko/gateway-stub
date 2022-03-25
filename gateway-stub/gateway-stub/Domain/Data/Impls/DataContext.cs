using System.Collections.Generic;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Domain.Enums;
using GatewayStub.Domain.Models.Dao;
using GatewayStub.Domain.Models.Json;

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
        public LootboxesDao Lootboxes { get; set; }

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
                CheckinSuccess = true,
                ApiVersion = "1.0.0",
                UserId = "1",
                AuthToken = "authToken1",
                TeamId = 1,
                RoomHost = "127.0.0.1",
                ProxyTcpPort = 7775,
                RoomConfig = new RoomConfig
                {
                    balancerMessage = "message",
                    balancerUrl = "http://localhost:5000",
                    proxyIp = "127.0.0.1",
                    roomId = 1,
                    roomPort = 10520,
                    tcpPort = 7776,
                    players = new List<Player>()
                    {
                        new Player
                        {
                            id = "2",
                            authToken = "authToken2",
                            team = 2,
                            heroId = 1,
                            heroStats = new HeroStats
                            {
                                strength = 1,
                                agility = 1,
                                intelligence = 1,
                                mainStat = EMainStat.Agility,
                                health = 100,
                                healthRegenPercent = "1",
                                armor = "1",
                                moveSpeed = "1",
                                attackDamage = 1,
                                attackReloadSpeed = "1",
                                skillPower = 1,
                                skillEffectPower = 1,
                                ultPower = 1,
                                ultEffectPower = 1,
                                vampirismPower = "1",
                            },
                        },
                        new Player
                        {
                            id = "3",
                            authToken = "authToken3",
                            team = 1,
                            heroId = 1,
                            heroStats = new HeroStats
                            {
                                strength = 1,
                                agility = 1,
                                intelligence = 1,
                                mainStat = EMainStat.Agility,
                                health = 100,
                                healthRegenPercent = "1",
                                armor = "1",
                                moveSpeed = "1",
                                attackDamage = 1,
                                attackReloadSpeed = "1",
                                skillPower = 1,
                                skillEffectPower = 1,
                                ultPower = 1,
                                ultEffectPower = 1,
                                vampirismPower = "1",
                            },
                        },
                        new Player
                        {
                            id = "4",
                            authToken = "authToken4",
                            team = 2,
                            heroId = 1,
                            heroStats = new HeroStats
                            {
                                strength = 1,
                                agility = 1,
                                intelligence = 1,
                                mainStat = EMainStat.Agility,
                                health = 100,
                                healthRegenPercent = "1",
                                armor = "1",
                                moveSpeed = "1",
                                attackDamage = 1,
                                attackReloadSpeed = "1",
                                skillPower = 1,
                                skillEffectPower = 1,
                                ultPower = 1,
                                ultEffectPower = 1,
                                vampirismPower = "1",
                            },
                        },
                        new Player
                        {
                            id = "5",
                            authToken = "authToken5",
                            team = 1,
                            heroId = 1,
                            heroStats = new HeroStats
                            {
                                strength = 1,
                                agility = 1,
                                intelligence = 1,
                                mainStat = EMainStat.Agility,
                                health = 100,
                                healthRegenPercent = "1",
                                armor = "1",
                                moveSpeed = "1",
                                attackDamage = 1,
                                attackReloadSpeed = "1",
                                skillPower = 1,
                                skillEffectPower = 1,
                                ultPower = 1,
                                ultEffectPower = 1,
                                vampirismPower = "1",
                            },
                        },
                        new Player
                        {
                            id = "6",
                            authToken = "authToken6",
                            team = 2,
                            heroId = 1,
                            heroStats = new HeroStats
                            {
                                strength = 1,
                                agility = 1,
                                intelligence = 1,
                                mainStat = EMainStat.Agility,
                                health = 100,
                                healthRegenPercent = "1",
                                armor = "1",
                                moveSpeed = "1",
                                attackDamage = 1,
                                attackReloadSpeed = "1",
                                skillPower = 1,
                                skillEffectPower = 1,
                                ultPower = 1,
                                ultEffectPower = 1,
                                vampirismPower = "1",
                            },
                        },
                    }
                }
            };

            Products = new ProductsDao
            {
                LootboxProducts  = new NetList<LootboxProductDto>
				{
					new LootboxProductDto
					{
						LootboxId = 1,
						Type = 1,
						ProductType = "Lootbox1",
						CurrencyType = "LIS",
						Price = "1"
					},
					new LootboxProductDto
					{
						LootboxId = 2,
						Type = 2,
						ProductType = "Lootbox2",
						CurrencyType = "LIS",
						Price = "5"
					},
					new LootboxProductDto
					{
						LootboxId = 3,
						Type = 3,
						ProductType = "Lootbox3",
						CurrencyType = "LIS",
						Price = "10"
					},
				},
                PromoCodeRewards = new NetList<PromoRewardDto>
                {
                },
                HeroProducts = new NetList<HeroPurchaseDto>
                {
                    new HeroPurchaseDto
                    {
                        HeroId = 3,
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
                        HeroId = 4,
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
                    new EquipmentItemDto
                    {
                        EquipmentItemId = 5,
                        BindingUid = 1,
                        BlockId = "0xc83a5bff85e800785904f8085f9d747224873dd2d88b751aee9bc85bcd069b34",
                        LinkToExplorer = "https://polkadot.js.org/apps/?rpc=wss%3A%2F%2Frpc.realis.network%2F#/explorer/query/0xc83a5bff85e800785904f8085f9d747224873dd2d88b751aee9bc85bcd069b34",
                        TransactionHash = "0x382c604197db6109dc1ad6677792772b6aa4f6e7fe4bd77c2d36a4019d65a6ae",
                        Effects = new NetList<EquipmentEffectDto>
                        {
                            new EquipmentEffectDto
                            {
                                StatToEffect = EHeroStatType.Agility,
                                Power = "9"
                            },
                            new EquipmentEffectDto
                            {
                                StatToEffect = EHeroStatType.Intelligence,
                                Power = "5"
                            }
                        },
                        IsPending = false
                    },
                    new EquipmentItemDto
                    {
                        EquipmentItemId = 11,
                        BindingUid = 2,
                        BlockId = "0xa9541b5ec818dacea2089872e44018e2f077eee7247b856a9e3c4fc1259550b2",
                        LinkToExplorer = "https://polkadot.js.org/apps/?rpc=wss%3A%2F%2Frpc.realis.network%2F#/explorer/query/0xa9541b5ec818dacea2089872e44018e2f077eee7247b856a9e3c4fc1259550b2",
                        TransactionHash = "0x382c604197db6109dc1ad6677792772b6aa4f6e7fe4bd77c2d36a4019d65a6ae",
                        Effects = new NetList<EquipmentEffectDto>
                        {
                            new EquipmentEffectDto
                            {
                                StatToEffect = EHeroStatType.Agility,
                                Power = "6"
                            },
                            new EquipmentEffectDto
                            {
                                StatToEffect = EHeroStatType.Intelligence,
                                Power = "9"
                            }
                        },
                        IsPending = false
                    },
                    new EquipmentItemDto
                    {
                        EquipmentItemId = 9,
                        BindingUid = 3,
                        BlockId = "0x72e47bdaf2866082ef8e3ad309e35c873788a9e4fbd963b5bc1769a06fc29253",
                        LinkToExplorer = "https://polkadot.js.org/apps/?rpc=wss%3A%2F%2Frpc.realis.network%2F#/explorer/query/0x72e47bdaf2866082ef8e3ad309e35c873788a9e4fbd963b5bc1769a06fc29253",
                        TransactionHash = "0xd484bea7d9a0c20d583e6c704bfe25d1443f65e0ce3f13d2907cf85ccd052352",
                        Effects = new NetList<EquipmentEffectDto>
                        {
                            new EquipmentEffectDto
                            {
                                StatToEffect = EHeroStatType.Agility,
                                Power = "6"
                            },
                            new EquipmentEffectDto
                            {
                                StatToEffect = EHeroStatType.Intelligence,
                                Power = "9"
                            }
                        },
                        IsPending = false
                    }
                },
                EquippedItemBindingUid = 1,
                EquippedItemSlotUid = 1,
                EquippedItemHeroUid = 1,
                EquipmentBonuses = new HeroStatsDto
                {
                    Agility = 1,
                    Armor = "1",
                    Health = 1,
                    Intelligence = 1,
                    Strength = 1,
                    AttackDamage = 1,
                    MainStat = EMainStat.Agility,
                    MoveSpeed = "1",
                    SkillPower = 1,
                    UltPower = 1,
                    VampirismPower = "1",
                    AttackReloadSpeed = "1",
                    HealthRegenPercent = "1",
                    SkillEffectPower = 1,
                    UltEffectPower = 1,
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
                AllHeroes = new NetList<AvailableHeroDto>
                {
                    new AvailableHeroDto
                    {
                        HeroId = 1,
                        Stats = new HeroStatsRangeDto
                        {
                            Strength = new[] {4, 6},                
                            Agility = new[] {5, 7},                 
                            Intelligence = new[] {8, 10},           
                            MainStat = EMainStat.Strength,          
                            Health = new[] {550, 560},              
                            HealthRegenPercent = new[] {"9", "11"}, 
                            Armor = new[] {"1", "2"},               
                            MoveSpeed = new[] {"2", "4"},           
                            AttackDamage = new[] {100, 110},        
                            AttackReloadSpeed = new[] {"10", "12"}, 
                            SkillPower = new[] {25, 35},            
                            SkillEffectPower = new[] {1, 2},        
                            UltPower = new[] {4, 6},                
                            UltEffectPower = new[] {1, 2},          
                            VampirismPower = new[] {"0", "1"},      
                        }
                    },
                    new AvailableHeroDto
                    {
                        HeroId = 3,
                        Stats = new HeroStatsRangeDto
                        {
                            Strength = new[] {5, 7},                  
                            Agility = new[] {8, 10},                  
                            Intelligence = new[] {4, 6},              
                            MainStat = EMainStat.Strength,            
                            Health = new[] {550, 600},                
                            HealthRegenPercent = new[] {"8", "12"},   
                            Armor = new[] {"8", "10"},                
                            MoveSpeed = new[] {"2", "4"},             
                            AttackDamage = new[] {150, 200},          
                            AttackReloadSpeed = new[] {"5", "10"},    
                            SkillPower = new[] {6, 8},                
                            SkillEffectPower = new[] {1, 2},          
                            UltPower = new[] {5, 7},                  
                            UltEffectPower = new[] {1, 2},            
                            VampirismPower = new[] {"0", "1"},        
                        }
                    },
                    new AvailableHeroDto
                    {
                        HeroId = 4,
                        Stats = new HeroStatsRangeDto
                        {
                            Strength = new[] {1, 2},
                            Agility = new[] {1, 2},
                            Intelligence = new[] {1, 2},
                            MainStat = EMainStat.Strength,
                            Health = new[] {600, 620},
                            HealthRegenPercent = new[] {"1", "2"},
                            Armor = new[] {"0", "1"},
                            MoveSpeed = new[] {"2", "4"},
                            AttackDamage = new[] {1, 2},
                            AttackReloadSpeed = new[] {"1", "2"},
                            SkillPower = new[] {1, 2},
                            SkillEffectPower = new[] {1, 2},
                            UltPower = new[] {1, 2},
                            UltEffectPower = new[] {1, 2},
                            VampirismPower = new[] {"0", "1"},
                        }
                    },
                    new AvailableHeroDto
                    {
                        HeroId = 5,
                        Stats = new HeroStatsRangeDto
                        {
                            Strength = new[] {4, 6},                
                            Agility = new[] {4, 6},                 
                            Intelligence = new[] {8, 10},           
                            MainStat = EMainStat.Strength,          
                            Health = new[] {600, 650},              
                            HealthRegenPercent = new[] {"8", "12"}, 
                            Armor = new[] {"5", "7"},               
                            MoveSpeed = new[] {"2", "4"},           
                            AttackDamage = new[] {90, 100},         
                            AttackReloadSpeed = new[] {"10", "12"}, 
                            SkillPower = new[] {5, 7},              
                            SkillEffectPower = new[] {1, 2},        
                            UltPower = new[] {4, 6},                
                            UltEffectPower = new[] {1, 2},          
                            VampirismPower = new[] {"0", "1"},      
                        }
                    },
                    new AvailableHeroDto
                    {
                        HeroId = 6,
                        Stats = new HeroStatsRangeDto
                        {
                            Strength = new[] {20, 25},
                            Agility = new[] {20, 25},
                            Intelligence = new[] {20, 30},
                            MainStat = EMainStat.Intelligence,
                            Health = new[] {600, 620},
                            HealthRegenPercent = new[] {"0.1", "0.2"},
                            Armor = new[] {"0", "1"},
                            MoveSpeed = new[] {"5", "6"},
                            AttackDamage = new[] {1, 2},
                            AttackReloadSpeed = new[] {"1", "2"},
                            SkillPower = new[] {1, 2},
                            SkillEffectPower = new[] {40, 50},
                            UltPower = new[] {1, 2},
                            UltEffectPower = new[] {1, 2},
                            VampirismPower = new[] {"0", "1"},
                        }
                    },
                },
                AvailableHeroes = new NetList<HeroDto>
                {
                    new HeroDto
                    {
                        HeroId = 1,
                        Level = 1,
                        Experience = 0,
                        MaxLevel = 10,
                        LevelupExperienceCost = 100,
                        LevelupScrollsCost = 10,
                        IsActive = true,
                        TransactionHash = "",
                        BindingUid = 1,
                        LinkToExplorer = "",
                        HeroStats = new HeroStatsDto
                        {
                            Strength = 5,
                            Agility = 6,
                            Intelligence = 9,
                            MainStat = EMainStat.Strength,
                            Health = 555,
                            HealthRegenPercent = "10",
                            Armor = "1",
                            MoveSpeed = "3",
                            AttackDamage = 105,
                            AttackReloadSpeed = "10.5",
                            SkillPower = 30,
                            SkillEffectPower = 1,
                            UltPower = 5,
                            UltEffectPower = 1,
                            VampirismPower = "0",
                        },
                        EquipmentBonuses = new HeroStatsDto
                        {
                            Strength = 0,
                            Agility = 0,
                            Intelligence = 0,
                            MainStat = EMainStat.Agility,
                            Health = 0,
                            HealthRegenPercent = "0",
                            Armor = "0",
                            MoveSpeed = "0",
                            AttackDamage = 0,
                            AttackReloadSpeed = "0",
                            SkillPower = 0,
                            SkillEffectPower = 0,
                            UltPower = 0,
                            UltEffectPower = 0,
                            VampirismPower = "0",
                        },
                        Slots = new NetList<SlotDto>
                        {
                            new SlotDto
                            {
                                BindingUid = 1,
                                Type = EEquipmentType.Weapon,
                                ItemUid = 0,
                            },
                            new SlotDto
                            {
                                BindingUid = 2,
                                Type = EEquipmentType.Armor,
                                ItemUid = 0,
                            },
                            new SlotDto
                            {
                                BindingUid = 3,
                                Type = EEquipmentType.Amulet,
                                ItemUid = 0,
                            }
                        },
                        BlockId = "",
                        IsPending = false
                    },
                    new HeroDto
                    {
                        HeroId = 3,
                        Level = 1,
                        Experience = 0,
                        MaxLevel = 10,
                        LevelupExperienceCost = 100,
                        LevelupScrollsCost = 10,
                        IsActive = false,
                        TransactionHash = "",
                        BindingUid = 2,
                        LinkToExplorer = "",
                        HeroStats = new HeroStatsDto
                        {
                            Strength = 6,
                            Agility = 9,
                            Intelligence = 5,
                            MainStat = EMainStat.Strength,
                            Health = 586,
                            HealthRegenPercent = "10",
                            Armor = "9",
                            MoveSpeed = "3",
                            AttackDamage = 156,
                            AttackReloadSpeed = "7",
                            SkillPower = 7,
                            SkillEffectPower = 1,
                            UltPower = 6,
                            UltEffectPower = 1,
                            VampirismPower = "0",
                        },
                        EquipmentBonuses = new HeroStatsDto
                        {
                            Strength = 0,
                            Agility = 0,
                            Intelligence = 0,
                            MainStat = EMainStat.Agility,
                            Health = 0,
                            HealthRegenPercent = "0",
                            Armor = "0",
                            MoveSpeed = "0",
                            AttackDamage = 0,
                            AttackReloadSpeed = "0",
                            SkillPower = 0,
                            SkillEffectPower = 0,
                            UltPower = 0,
                            UltEffectPower = 0,
                            VampirismPower = "0",
                        },
                        Slots = new NetList<SlotDto>
                        {
                            new SlotDto
                            {
                                BindingUid = 4,
                                Type = EEquipmentType.Weapon,
                                ItemUid = 0,
                            },
                            new SlotDto
                            {
                                BindingUid = 5,
                                Type = EEquipmentType.Armor,
                                ItemUid = 0,
                            },
                            new SlotDto
                            {
                                BindingUid = 6,
                                Type = EEquipmentType.Amulet,
                                ItemUid = 0,
                            }
                        },
                        BlockId = "",
                        IsPending = false
                    },
                    new HeroDto
                    {
                        HeroId = 5,
                        Level = 1,
                        Experience = 0,
                        MaxLevel = 10,
                        LevelupExperienceCost = 100,
                        LevelupScrollsCost = 10,
                        IsActive = false,
                        TransactionHash = "",
                        BindingUid = 3,
                        LinkToExplorer = "",
                        HeroStats = new HeroStatsDto
                        {
                            Strength = 5,
                            Agility = 6,
                            Intelligence = 9,
                            MainStat = EMainStat.Strength,
                            Health = 625,
                            HealthRegenPercent = "10",
                            Armor = "6",
                            MoveSpeed = "3",
                            AttackDamage = 95,
                            AttackReloadSpeed = "11",
                            SkillPower = 6,
                            SkillEffectPower = 1,
                            UltPower = 5,
                            UltEffectPower = 1,
                            VampirismPower = "0",
                        },
                        EquipmentBonuses = new HeroStatsDto
                        {
                            Strength = 0,
                            Agility = 0,
                            Intelligence = 0,
                            MainStat = EMainStat.Agility,
                            Health = 0,
                            HealthRegenPercent = "0",
                            Armor = "0",
                            MoveSpeed = "0",
                            AttackDamage = 0,
                            AttackReloadSpeed = "0",
                            SkillPower = 0,
                            SkillEffectPower = 0,
                            UltPower = 0,
                            UltEffectPower = 0,
                            VampirismPower = "0",
                        },
                        Slots = new NetList<SlotDto>
                        {
                            new SlotDto
                            {
                                BindingUid = 7,
                                Type = EEquipmentType.Weapon,
                                ItemUid = 0,
                            },
                            new SlotDto
                            {
                                BindingUid = 8,
                                Type = EEquipmentType.Armor,
                                ItemUid = 0,
                            },
                            new SlotDto
                            {
                                BindingUid = 9,
                                Type = EEquipmentType.Amulet,
                                ItemUid = 0,
                            }
                        },
                        BlockId = "",
                        IsPending = false
                    }
                },
                EquipHeroSuccess = true,
                ScrollsAmount = 100,
                UndistributedExperience = 0,
                SelectedHeroUid = 1
            };

            Leaderboard = new LeaderboardDao
            {
                CurrentPage = 1,
                Pages = 1,
                Leaderboard = new NetList<LeaderboardPlaceDto>
                {
                    new LeaderboardPlaceDto
                    {
                        Place = 1,
                        Rating = 0,
                        Username = "TestUser1"
                    },
                    new LeaderboardPlaceDto
                    {
                        Place = 2,
                        Rating = 0,
                        Username = "TestUser2"
                    },
                    new LeaderboardPlaceDto
                    {
                        Place = 3,
                        Rating = 0,
                        Username = "TestUser3"
                    },
                    new LeaderboardPlaceDto
                    {
                        Place = 4,
                        Rating = 0,
                        Username = "TestUser4"
                    },
                    new LeaderboardPlaceDto
                    {
                        Place = 5,
                        Rating = 0,
                        Username = "TestUser5"
                    },
                    new LeaderboardPlaceDto
                    {
                        Place = 6,
                        Rating = 0,
                        Username = "TestUser6"
                    },
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
                Email = "googler@gmail.com",
                TokensIncreaseBy = "1",
                SetImageSuccess = true,
                SetUsernameSuccess = true,
            };

            Lootboxes = new LootboxesDao
            {
                UserLootboxes = new NetList<LootboxDto>
                {
                    new LootboxDto
                    {
                        LootboxId = 1,
                        BindingUid = 1,
                    },
                    new LootboxDto
                    {
                        LootboxId = 2,
                        BindingUid = 2,
                    },
                },
            };
        }
    }
}