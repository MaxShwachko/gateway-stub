using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Auth;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Auth
{
    public class AuthResetPasswordDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthResetPassword;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var hash = reader.ReadString();
            var password = reader.ReadString();

            return new AuthResetPasswordRequest(hash, password);
        }
    }
}