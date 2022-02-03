using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests;
using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders
{
    public class PingPongReader : IRequestReader
    {
        public byte Header => (byte) EHeader.PingPong;

        public IRequest Read(byte[] bytes)
        {
            return new PingPongRequest();
        }
    }
}