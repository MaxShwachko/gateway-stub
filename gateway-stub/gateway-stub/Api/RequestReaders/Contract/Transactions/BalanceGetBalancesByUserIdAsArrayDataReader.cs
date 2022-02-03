using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Transactions;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Transactions
{
    public class BalanceGetBalancesByUserIdAsArrayDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Transactions;
        public byte MethodId => (byte) EMethodId.BalanceGetBalancesByUserIdAsArray;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            return new BalanceGetBalancesByUserIdAsArrayRequest();
        }
    }
}