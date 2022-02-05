using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Test
{
    public class SpendExperienceRequest : IContractRequestData
    {
        public readonly int HeroUid;

        public SpendExperienceRequest(int heroUid)
        {
            HeroUid = heroUid;
        }
    }
}