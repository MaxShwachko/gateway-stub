using System;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using GatewayStub.Domain.Data;
using GatewayStub.Domain.Models.Json;
using Newtonsoft.Json;

namespace GatewayStub.Domain.Services.Impls
{
    public class MatchmakingService : IMatchmakingService
    {
        public RoomConfig RoomConfig { get; private set; }

        private readonly IDataContext _dataContext;
        private readonly HttpClient _httpClient;

        public MatchmakingService(IDataContext dataContext, IHttpClientFactory httpClientFactory)
        {
            _dataContext = dataContext;
            RoomConfig = (RoomConfig) dataContext.Matchmaking.RoomConfig.Clone();
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("http://127.0.0.1:4444/");
        }

        public async Task StartMatchmaking()
        {
            var selectedHeroUid = _dataContext.Heroes.SelectedHeroUid;
            var userId = _dataContext.Matchmaking.UserId;
            var authToken = _dataContext.Matchmaking.AuthToken;
            var selectedHero = _dataContext.Heroes.AvailableHeroes.FirstOrDefault(h => h.BindingUid == selectedHeroUid);

            if (selectedHero == null)
            {
                Console.WriteLine($"Couldn't find hero with binding UID = {selectedHeroUid}");
                return;
            }

            RoomConfig = (RoomConfig) _dataContext.Matchmaking.RoomConfig.Clone();
            var userPlayer = new Player()
            {
                id = userId,
                team = 1,
                authToken = authToken,
                heroId = selectedHero.HeroId,
                heroStats = HeroStats.FromDto(selectedHero.HeroStats)
            };
            RoomConfig.players.Add(userPlayer);
            var serialize = JsonConvert.SerializeObject(RoomConfig);

            var requestBodyJson = new StringContent(
                serialize,
                Encoding.UTF8,
                MediaTypeNames.Application.Json);
            await _httpClient.PostAsync(string.Empty, requestBodyJson);
        }
    }
}