using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Test
{
    public class OpenLootboxRequest : IContractRequestData
    {
        public readonly int BindingUid;

        public OpenLootboxRequest(int bindingUid)
        {
            BindingUid = bindingUid;
        }
    }
}