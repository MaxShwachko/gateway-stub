using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Balances;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Balances
{
    public class BalancesGetFreeExperienceBalanceDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Balances;
        public byte MethodId => (byte) EMethodId.BalancesGetFreeExperienceBalance;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            return new BalancesGetFreeExperienceBalanceRequest();
        }
    }
}