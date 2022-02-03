using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Lobby
{
    public class StatsEquipItemRequest : IContractRequestData
    {
        public readonly int BindingUid;
        public readonly int SlotUid;
        public readonly int HeroUid;

        public StatsEquipItemRequest(int bindingUid, int slotUid, int heroUid)
        {
            BindingUid = bindingUid;
            SlotUid = slotUid;
            HeroUid = heroUid;
        }
    }
}