using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Auth;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Auth
{
    public class AuthResentConfirmationMailDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthResentConfirmationMail;
        
        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var email = reader.ReadString();

            return new AuthResentConfirmationMailRequest(email);
        }
    }
}