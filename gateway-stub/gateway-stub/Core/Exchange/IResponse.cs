using GatewayStub.ByteFormatter;

namespace GatewayStub.Core.Exchange
{
    public interface IResponse
    {
        byte GetHeader();
        void Write(ByteWriter writer);
    }
}