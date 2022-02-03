using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Lobby
{
    public class StatsUnequipItemRequest : IContractRequestData
    {
        public readonly int BindingUid;
        public readonly int HeroBindingId;

        public StatsUnequipItemRequest(int bindingUid, int heroBindingId)
        {
            BindingUid = bindingUid;
            HeroBindingId = heroBindingId;
        }
    }
}