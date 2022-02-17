using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Auth;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Auth
{
    public class AuthLoginDataReader : IContractRequestDataReader
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthLogin;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var username = reader.ReadString();
            var password = reader.ReadString();
            var deviceId = reader.ReadString();

            return new AuthLoginRequest(username, password, deviceId);
        }
    }
}