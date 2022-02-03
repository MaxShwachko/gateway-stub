using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Auth;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Auth
{
    public class AuthCreateRequestToConfirmEmailDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthCreateRequestToConfirmEmail;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var email = reader.ReadString();
            var referralCode = reader.ReadString();

            return new AuthCreateRequestToConfirmEmailRequest(email, referralCode);
        }
    }
}