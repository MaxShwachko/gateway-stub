using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Promo
{
    public class CodesUseRequest : IContractRequestData
    {
        public readonly string Code;

        public CodesUseRequest(string code)
        {
            Code = code;
        }
    }
}