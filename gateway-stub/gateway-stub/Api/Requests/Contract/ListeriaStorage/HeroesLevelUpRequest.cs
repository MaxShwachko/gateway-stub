using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.ListeriaStorage
{
    public class  HeroesLevelUpRequest : IContractRequestData
    {
        public readonly int HeroUid;

        public HeroesLevelUpRequest(int heroUid)
        {
            HeroUid = heroUid;
        }
    }
}