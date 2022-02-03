using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Transactions
{
    public class BalanceGetListWithPaginationRequest : IContractRequestData
    {
        public readonly short Page;

        public BalanceGetListWithPaginationRequest(short page)
        {
            Page = page;
        }
    }
}