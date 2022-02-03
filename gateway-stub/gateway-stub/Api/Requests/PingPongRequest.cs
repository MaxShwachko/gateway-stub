using GatewayStub.Api.Enums;
using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Requests
{
    public class PingPongRequest : IRequest
    {
        public byte GetHeader() => (byte) EHeader.PingPong;
    }
}