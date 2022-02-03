using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests.Contract.Transactions
{
    public class BalanceGetBalanceByUserIdRequest : IContractRequestData
    {
        public readonly string Currency;

        public BalanceGetBalanceByUserIdRequest(string currency)
        {
            Currency = currency;
        }
    }
}