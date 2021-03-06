using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests
{
    public class HandshakeRequest : IRequest
    {
        public byte GetHeader() => (byte) EHeader.Handshake;

        public readonly byte AppId;
        public readonly string AuthToken;
        public readonly string ApiVersion;
        public readonly string SessionToken;

        public HandshakeRequest(byte appId, string authToken, string apiVersion, string sessionToken)
		{
			AppId = appId;
			AuthToken = authToken;
            ApiVersion = apiVersion;
            SessionToken = sessionToken;
        }
    }
}