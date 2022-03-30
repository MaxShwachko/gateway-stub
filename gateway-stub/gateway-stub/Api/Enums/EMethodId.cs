﻿namespace GatewayStub.Api.Enums
{
    public enum EMethodId : byte
    {
        AuthLogin = 1,
        AuthSendRequestToResetPassword = 2,
        AuthResetPassword = 3,
        AuthConfirmPassword = 4,
        AuthCreateRequestToConfirmEmail = 5,
        AuthConfirmEmailByCode = 6,
        AuthDeleteEmailRequest = 7,
        AuthSetPassword = 8,
        AuthResentConfirmationMail = 9,
        AuthLogout = 10,
        AuthEmptyMethod = 11,
        AuthAssignProviderAccountToDeviceId = 12,
		BalancesGetFreeExperienceBalance = 19,
		BalancesFreeExperienceAddedNotification = 20,
		GameBalancerStopSearching = 21,
		GameBalancerGameStartedNotification = 22,
		HeroesGetHeroesListByUserId = 23,
		HeroesGiveFreeExperienceToHero = 24,
		HeroesHeroAddedNotification = 25,
		HeroesLevelUp = 26,
		HeroesStatsUpdatedNotification = 27,
		InventoryGetLootboxesList = 28,
		InventoryOpenLootbox = 29,
		InventoryGetItemsList = 30,
		InventoryGetScrollsCount = 31,
		HeroesGetHeroesList = 33,
		InventoryAddedItemNotification = 34,
		InventoryAddedUnequippableItemNotification = 35,
		LobbyStartGame = 36,
        GetRegions = 37,
        RegionsSet = 38,
        UserGetSettings = 39,
        UserSetSettings = 40,
        StatsEquipItem = 41,
        StatsEquipHero = 42,
        StatsUnequipItem = 43,
        UserGetUserData = 44,
        UserUpdateUsername = 45,
        UserGetLeaderBoard = 46,
        UserUpdateProfileImage = 47,
		ItemsGetLootboxesList = 48,
		ProductLootboxOpenedNotification = 50,
        CodesUse = 51,
        BalanceUserBalanceChangedNotification = 52,
        ProductPurchase = 53,
        ProductGetHeroList = 54,
        ProductGetEquipmentList = 55,
        WalletGetByUserId = 56,
        BalanceGetBalanceByUserId = 58,
        BalanceGetBalancesByUserIdAsArray = 60,
        BalanceGetListWithPagination = 61,
        Checkin = 127,
    }
}