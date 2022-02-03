using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Transactions;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Transactions
{
    public class BalanceGetListWithPaginationDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Transactions;
        public byte MethodId => (byte) EMethodId.BalanceGetListWithPagination;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var page = reader.ReadInt16();

            return new BalanceGetListWithPaginationRequest(page);
        }
    }
}