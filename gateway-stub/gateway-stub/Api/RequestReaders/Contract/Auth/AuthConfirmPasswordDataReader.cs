using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Auth;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Auth
{
    public class AuthConfirmPasswordDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthConfirmPassword;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var password = reader.ReadString();

            return new AuthConfirmPasswordRequest(password);
        }
    }
}