using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses
{
    public class PingPongResponse : IResponse
    {
        public byte GetHeader() => (byte) EHeader.PingPong;

        public void Write(ByteWriter writer)
        {
            
        }
    }
}