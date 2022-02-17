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
            container.AddSingleton<IContractRequestReader, AuthAssignProviderAccountToDeviceIdDataReader>();
            container.AddSingleton<IContractRequestReader, AuthConfirmEmailByCodeDataReader>();
            container.AddSingleton<IContractRequestReader, AuthConfirmPasswordDataReader>();
            container.AddSingleton<IContractRequestReader, AuthCreateRequestToConfirmEmailDataReader>();
            container.AddSingleton<IContractRequestReader, AuthDeleteEmailRequestDataReader>();
            container.AddSingleton<IContractRequestReader, AuthEmptyMethodDataReader>();
            container.AddSingleton<IContractRequestReader, AuthLoginDataReader>();
            container.AddSingleton<IContractRequestReader, AuthLogoutDataReader>();
            container.AddSingleton<IContractRequestReader, AuthResentConfirmationMailDataReader>();
            container.AddSingleton<IContractRequestReader, AuthResetPasswordDataReader>();
            container.AddSingleton<IContractRequestReader, AuthSendRequestToResetPasswordDataReader>();
            container.AddSingleton<IContractRequestReader, AuthSetPasswordDataReader>();
            container.AddSingleton<IContractRequestReader, GameBalancerStopSearchingDataReader>();
            container.AddSingleton<IContractRequestReader, GetRegionsDataReader>();
            container.AddSingleton<IContractRequestReader, HeroesGetHeroesListByUserIdDataReader>();
            container.AddSingleton<IContractRequestReader, InventoryGetItemsListDataReader>();
            container.AddSingleton<IContractRequestReader, LobbyStartGameDataReader>();
            container.AddSingleton<IContractRequestReader, RegionsSetDataReader>();
            container.AddSingleton<IContractRequestReader, StatsEquipHeroDataReader>();
            container.AddSingleton<IContractRequestReader, StatsEquipItemDataReader>();
            container.AddSingleton<IContractRequestReader, StatsUnequipItemDataReader>();
            container.AddSingleton<IContractRequestReader, UserGetLeaderBoardDataReader>();
            container.AddSingleton<IContractRequestReader, UserGetSettingsDataReader>();
            container.AddSingleton<IContractRequestReader, UserGetUserDataDataReader>();
            container.AddSingleton<IContractRequestReader, UserSetSettingsDataReader>();
            container.AddSingleton<IContractRequestReader, UserUpdateProfileImageDataReader>();
            container.AddSingleton<IContractRequestReader, UserUpdateUsernameDataReader>();
            container.AddSingleton<IContractRequestReader, ItemsGetListOfAvailableDataReader>();
            container.AddSingleton<IContractRequestReader, CodesUseDataReader>();
            container.AddSingleton<IContractRequestReader, ProductGetHeroListDataReader>();
            container.AddSingleton<IContractRequestReader, ProductPurchaseDataReader>();
            container.AddSingleton<IContractRequestReader, WalletGetByUserIdDataReader>();
            container.AddSingleton<IContractRequestReader, BalanceGetBalanceByUserIdDataReader>();
            container.AddSingleton<IContractRequestReader, BalanceGetBalancesByUserIdAsArrayDataReader>();
            container.AddSingleton<IContractRequestReader, BalanceGetListWithPaginationDataReader>();
            container.AddSingleton<IContractRequestReader, GetScrollsDataReader>();
            container.AddSingleton<IContractRequestReader, GetUndistributedExperienceDataReader>();
            container.AddSingleton<IContractRequestReader, LevelupHeroDataReader>();
            container.AddSingleton<IContractRequestReader, SpendExperienceDataReader>();

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