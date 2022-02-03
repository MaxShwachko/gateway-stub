using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Auth;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Auth
{
    public class AuthSetPasswordDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthSetPassword;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var hash = reader.ReadString();
            var password = reader.ReadString();
            var deviceId = reader.ReadString();

            return new AuthSetPasswordRequest(hash, password, deviceId);
        }
    }
}