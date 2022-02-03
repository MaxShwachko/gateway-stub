using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Lobby
{
    public class RegionsSetRequest : IContractRequestData
    {
        public readonly string RegionName;
        public readonly bool IsFixed;

        public RegionsSetRequest(string regionName, bool isFixed)
        {
            RegionName = regionName;
            IsFixed = isFixed;
        }
    }
}