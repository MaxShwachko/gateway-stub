using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.ListeriaStorage
{
    public class HeroesGiveFreeExperienceToHeroRequest : IContractRequestData
    {
        public readonly int HeroUid;

        public HeroesGiveFreeExperienceToHeroRequest(int heroUid)
        {
            HeroUid = heroUid;
        }
    }
}