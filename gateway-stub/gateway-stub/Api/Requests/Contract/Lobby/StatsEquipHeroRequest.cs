using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Lobby
{
    public class StatsEquipHeroRequest : IContractRequestData
    {
        public readonly int BindingUid;

        public StatsEquipHeroRequest(int bindingUid)
        {
            BindingUid = bindingUid;
        }
    }
}