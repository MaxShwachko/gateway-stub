using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Auth;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Auth
{
    public class AuthSendRequestToResetPasswordDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthSendRequestToResetPassword;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var email = reader.ReadString();

            return new AuthSendRequestToResetPasswordRequest(email);
        }
    }
}