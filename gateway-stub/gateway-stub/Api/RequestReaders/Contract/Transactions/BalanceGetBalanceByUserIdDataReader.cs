using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Transactions;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Transactions
{
    public class BalanceGetBalanceByUserIdDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Transactions;
        public byte MethodId => (byte) EMethodId.BalanceGetBalanceByUserId;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var currency = reader.ReadString();

            return new BalanceGetBalanceByUserIdRequest(currency);
        }
    }
}