using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Auth;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Auth
{
    public class AuthEmptyMethodDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthEmptyMethod;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            return new AuthEmptyMethodRequest();
        }
    }
}