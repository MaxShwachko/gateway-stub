using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses
{
    public class HandshakeResponse : IResponse
    {
        public byte GetHeader() => (byte) EHeader.Handshake;

        public readonly bool Success;
        public readonly string SessionToken;
        public readonly string Error;
        public readonly HandshakeErrorCode? ErrorCode;

        public HandshakeResponse(bool success, string sessionToken, string error, HandshakeErrorCode? errorCode)
        {
            Success = success;
            SessionToken = sessionToken;
            Error = error;
            ErrorCode = errorCode;
        }

        public void Write(ByteWriter writer)
        {
            writer.Write(Success);
            writer.Write(SessionToken);
            writer.Write(Error);
            writer.Write((byte?) ErrorCode);
        }
    }
}