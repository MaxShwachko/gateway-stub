using GatewayStub.Api.HttpHandlers;
using GatewayStub.Api.RequestHandlers;
using GatewayStub.Api.RequestHandlers.Contract.Auth;
using GatewayStub.Api.RequestHandlers.Contract.GameBalancer;
using GatewayStub.Api.RequestHandlers.Contract.Lobby;
using GatewayStub.Api.RequestHandlers.Contract.Market;
using GatewayStub.Api.RequestHandlers.Contract.Promo;
using GatewayStub.Api.RequestHandlers.Contract.Purchase;
using GatewayStub.Api.RequestHandlers.Contract.Test;
using GatewayStub.Api.RequestHandlers.Contract.Transactions;
using GatewayStub.Api.RequestReaders;
using GatewayStub.Api.RequestReaders.Contract.Auth;
using GatewayStub.Api.RequestReaders.Contract.GameBalancer;
using GatewayStub.Api.RequestReaders.Contract.Lobby;
using GatewayStub.Api.RequestReaders.Contract.Market;
using GatewayStub.Api.RequestReaders.Contract.Promo;
using GatewayStub.Api.RequestReaders.Contract.Purchase;
using GatewayStub.Api.RequestReaders.Contract.Test;
using GatewayStub.Api.RequestReaders.Contract.Transactions;
using GatewayStub.Core.Exchange;
using GatewayStub.Core.Http;
using GatewayStub.Core.Http.Impls;
using GatewayStub.Core.WebSocket;
using GatewayStub.Core.WebSocket.Impls;
using GatewayStub.Domain.Data;
using GatewayStub.Domain.Data.Impls;
using GatewayStub.Domain.Services;
using GatewayStub.Domain.Services.Impls;
using Microsoft.Extensions.DependencyInjection;

namespace GatewayStub.Configuration
{
    public static class DiConfig
    {
        public static void ConfigureDependencies(this IServiceCollection container)
        {
            //RequestReaders
            container.AddSingleton<IRequestReader, PingPongReader>();
            container.AddSingleton<IRequestReader, HandshakeReader>();
            container.AddSingleton<IRequestReader, ContractRequestReader>();

            //RequestHandlers
            container.AddSingleton<IRequestHandler, PingPongHandler>();
            container.AddSingleton<IRequestHandler, HandshakeHandler>();
            container.AddSingleton<IRequestHandler, ContractRequestHandler>();

            //ContractRequestReaders
            container.AddSingleton<IContractRequestDataReader, AuthAssignProviderAccountToDeviceIdDataReader>();
            container.AddSingleton<IContractRequestDataReader, AuthConfirmEmailByCodeDataReader>();
            container.AddSingleton<IContractRequestDataReader, AuthConfirmPasswordDataReader>();
            container.AddSingleton<IContractRequestDataReader, AuthCreateRequestToConfirmEmailDataReader>();
            container.AddSingleton<IContractRequestDataReader, AuthDeleteEmailRequestDataReader>();
            container.AddSingleton<IContractRequestDataReader, AuthEmptyMethodDataReader>();
            container.AddSingleton<IContractRequestDataReader, AuthLoginDataReader>();
            container.AddSingleton<IContractRequestDataReader, AuthLogoutDataReader>();
            container.AddSingleton<IContractRequestDataReader, AuthResentConfirmationMailDataReader>();
            container.AddSingleton<IContractRequestDataReader, AuthResetPasswordDataReader>();
            container.AddSingleton<IContractRequestDataReader, AuthSendRequestToResetPasswordDataReader>();
            container.AddSingleton<IContractRequestDataReader, AuthSetPasswordDataReader>();
            container.AddSingleton<IContractRequestDataReader, GameBalancerStopSearchingDataReader>();
            container.AddSingleton<IContractRequestDataReader, GetRegionsDataReader>();
            container.AddSingleton<IContractRequestDataReader, HeroesGetHeroesListByUserIdDataReader>();
            container.AddSingleton<IContractRequestDataReader, InventoryGetItemsListDataReader>();
            container.AddSingleton<IContractRequestDataReader, LobbyStartGameDataReader>();
            container.AddSingleton<IContractRequestDataReader, RegionsSetDataReader>();
            container.AddSingleton<IContractRequestDataReader, StatsEquipHeroDataReader>();
            container.AddSingleton<IContractRequestDataReader, StatsEquipItemDataReader>();
            container.AddSingleton<IContractRequestDataReader, StatsUnequipItemDataReader>();
            container.AddSingleton<IContractRequestDataReader, UserGetLeaderBoardDataReader>();
            container.AddSingleton<IContractRequestDataReader, UserGetSettingsDataReader>();
            container.AddSingleton<IContractRequestDataReader, UserGetUserDataDataReader>();
            container.AddSingleton<IContractRequestDataReader, UserSetSettingsDataReader>();
            container.AddSingleton<IContractRequestDataReader, UserUpdateProfileImageDataReader>();
            container.AddSingleton<IContractRequestDataReader, UserUpdateUsernameDataReader>();
            container.AddSingleton<IContractRequestDataReader, ItemsGetListOfAvailableDataReader>();
            container.AddSingleton<IContractRequestDataReader, CodesUseDataReader>();
            container.AddSingleton<IContractRequestDataReader, ProductGetHeroListDataReader>();
            container.AddSingleton<IContractRequestDataReader, ProductPurchaseDataReader>();
            container.AddSingleton<IContractRequestDataReader, WalletGetByUserIdDataReader>();
            container.AddSingleton<IContractRequestDataReader, BalanceGetBalanceByUserIdDataReader>();
            container.AddSingleton<IContractRequestDataReader, BalanceGetBalancesByUserIdAsArrayDataReader>();
            container.AddSingleton<IContractRequestDataReader, BalanceGetListWithPaginationDataReader>();
            container.AddSingleton<IContractRequestDataReader, GetScrollsDataReader>();
            container.AddSingleton<IContractRequestDataReader, GetUndistributedExperienceDataReader>();
            container.AddSingleton<IContractRequestDataReader, LevelupHeroDataReader>();
            container.AddSingleton<IContractRequestDataReader, SpendExperienceDataReader>();
            container.AddSingleton<IContractRequestDataReader, GetAllHeroesListDataReader>();
            container.AddSingleton<IContractRequestDataReader, GetLootboxesListDataReader>();
            container.AddSingleton<IContractRequestDataReader, GetLootboxProductsDataReader>();
            container.AddSingleton<IContractRequestDataReader, OpenLootboxDataReader>();

            //ContractRequestHandlers
            container.AddSingleton<IContractRequestHandler, AuthAssignProviderAccountToDeviceIdHandler>();
            container.AddSingleton<IContractRequestHandler, AuthConfirmEmailByCodeHandler>();
            container.AddSingleton<IContractRequestHandler, AuthConfirmPasswordHandler>();
            container.AddSingleton<IContractRequestHandler, AuthCreateRequestToConfirmEmailHandler>();
            container.AddSingleton<IContractRequestHandler, AuthDeleteEmailRequestHandler>();
            container.AddSingleton<IContractRequestHandler, AuthEmptyMethodHandler>();
            container.AddSingleton<IContractRequestHandler, AuthLoginHandler>();
            container.AddSingleton<IContractRequestHandler, AuthLogoutHandler>();
            container.AddSingleton<IContractRequestHandler, AuthResentConfirmationMailHandler>();
            container.AddSingleton<IContractRequestHandler, AuthResetPasswordHandler>();
            container.AddSingleton<IContractRequestHandler, AuthSendRequestToResetPasswordHandler>();
            container.AddSingleton<IContractRequestHandler, AuthSetPasswordHandler>();
            container.AddSingleton<IContractRequestHandler, GameBalancerStopSearchingHandler>();
            container.AddSingleton<IContractRequestHandler, GetRegionsHandler>();
            container.AddSingleton<IContractRequestHandler, HeroesGetHeroesListByUserIdHandler>();
            container.AddSingleton<IContractRequestHandler, InventoryGetItemsListHandler>();
            container.AddSingleton<IContractRequestHandler, LobbyStartGameHandler>();
            container.AddSingleton<IContractRequestHandler, RegionsSetHandler>();
            container.AddSingleton<IContractRequestHandler, StatsEquipHeroHandler>();
            container.AddSingleton<IContractRequestHandler, StatsEquipItemHandler>();
            container.AddSingleton<IContractRequestHandler, StatsUnequipItemHandler>();
            container.AddSingleton<IContractRequestHandler, UserGetLeaderBoardHandler>();
            container.AddSingleton<IContractRequestHandler, UserGetSettingsHandler>();
            container.AddSingleton<IContractRequestHandler, UserGetUserDataHandler>();
            container.AddSingleton<IContractRequestHandler, UserSetSettingsHandler>();
            container.AddSingleton<IContractRequestHandler, UserUpdateProfileImageHandler>();
            container.AddSingleton<IContractRequestHandler, UserUpdateUsernameHandler>();
            container.AddSingleton<IContractRequestHandler, ItemsGetListOfAvailableHandler>();
            container.AddSingleton<IContractRequestHandler, CodesUseHandler>();
            container.AddSingleton<IContractRequestHandler, ProductGetHeroListHandler>();
            container.AddSingleton<IContractRequestHandler, ProductPurchaseHandler>();
            container.AddSingleton<IContractRequestHandler, WalletGetByUserIdHandler>();
            container.AddSingleton<IContractRequestHandler, BalanceGetBalanceByUserIdHandler>();
            container.AddSingleton<IContractRequestHandler, BalanceGetBalancesByUserIdAsArrayHandler>();
            container.AddSingleton<IContractRequestHandler, BalanceGetListWithPaginationHandler>();
            container.AddSingleton<IContractRequestHandler, GetScrollsHandler>();
            container.AddSingleton<IContractRequestHandler, GetUndistributedExperienceHandler>();
            container.AddSingleton<IContractRequestHandler, LevelupHeroHandler>();
            container.AddSingleton<IContractRequestHandler, SpendExperienceHandler>();
            container.AddSingleton<IContractRequestHandler, GetAllHeroesListHandler>();
            container.AddSingleton<IContractRequestHandler, GetLootboxesListHandler>();
            container.AddSingleton<IContractRequestHandler, GetLootboxProductsHandler>();
            container.AddSingleton<IContractRequestHandler, OpenLootboxHandler>();

            //HttpHandlers
            container.AddSingleton<IHttpHandler, RoomOverHandler>();
            container.AddSingleton<IHttpHandler, RoomReadyHandler>();

            //Services
            container.AddSingleton<IWebSocketReader, WebSocketReader>();
            container.AddSingleton<IWebSocketWrapper, WebSocketWrapper>();
            container.AddSingleton<IWebSocketListener, WebSocketListener>();
            container.AddSingleton<IHttpListener, HttpListener>();
            container.AddSingleton<IDataContext, DataContext>();
            container.AddSingleton<IMatchmakingService, MatchmakingService>();
        }
    }
}