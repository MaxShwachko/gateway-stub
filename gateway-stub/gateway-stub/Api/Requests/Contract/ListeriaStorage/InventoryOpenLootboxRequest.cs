using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.ListeriaStorage
{
    public class InventoryOpenLootboxRequest : IContractRequestData
    {
        public readonly int BindingUid;

        public InventoryOpenLootboxRequest(int bindingUid)
        {
            BindingUid = bindingUid;
        }
    }
}