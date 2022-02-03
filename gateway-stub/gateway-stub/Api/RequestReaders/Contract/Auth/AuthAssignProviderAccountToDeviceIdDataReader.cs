using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests.Contract.Auth;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders.Contract.Auth
{
    public class AuthAssignProviderAccountToDeviceIdDataReader : IContractRequestReader
    {
        public byte AgentId => (byte) EAgentId.Auth;
        public byte MethodId => (byte) EMethodId.AuthAssignProviderAccountToDeviceId;

        public IContractRequestData ReadRequest(ByteReader reader)
        {
            var token = reader.ReadString();

            return new AuthAssignProviderAccountToDeviceIdRequest(token);
        }
    }
}