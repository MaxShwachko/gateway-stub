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
		InventoryGetLootboxesList = 27,
		InventoryOpenLootbox = 28,
		InventoryGetItemsList = 29,
		InventoryGetScrollsCount = 30,
		HeroesGetHeroesList = 32,
		InventoryAddedItemNotification = 33,
		InventoryAddedUnequippableItemNotification = 34,
		LobbyStartGame = 35,
        GetRegions = 36,
        RegionsSet = 37,
        UserGetSettings = 38,
        UserSetSettings = 39,
        StatsEquipItem = 40,
        StatsEquipHero = 41,
        StatsUnequipItem = 42,
        UserGetUserData = 43,
        UserUpdateUsername = 44,
        UserGetLeaderBoard = 45,
        UserUpdateProfileImage = 46,
		ItemsGetLootboxesList = 47,
		ProductLootboxOpenedNotification = 49,
        CodesUse = 50,
        BalanceUserBalanceChangedNotification = 51,
        ProductPurchase = 52,
        ProductGetHeroList = 53,
        ProductGetEquipmentList = 54,
        WalletGetByUserId = 55,
        BalanceGetBalanceByUserId = 57,
        BalanceGetBalancesByUserIdAsArray = 59,
        BalanceGetListWithPagination = 60,
        Checkin = 127,
		HeroStatsUpdatedNotification = 200,
    }
}