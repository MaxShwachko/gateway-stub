using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Auth;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Auth
{
    public class AuthDeleteEmailRequestDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthDeleteEmailRequest;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var emailHash = reader.ReadString();

            return new AuthDeleteEmailRequest(emailHash);
        }
    }
}