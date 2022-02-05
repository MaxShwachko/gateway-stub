using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Test
{
    public class LevelupHeroRequest : IContractRequestData
    {
        public readonly int HeroUid;

        public LevelupHeroRequest(int heroUid)
        {
            HeroUid = heroUid;
        }
    }
}