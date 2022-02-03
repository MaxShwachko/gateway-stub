using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;

namespace GatewayStub.Domain.Models.Dao
{
    public class BalanceDao
    {
        public string BalanceAmount;
        public NetList<BalanceDto> Currencies;
        public short TransactionsCurrentPage;
        public short TransactionsPages;
        public NetList<TransactionDto> Transactions;
    }
}