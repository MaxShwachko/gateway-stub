namespace GatewayStub.Core.Exchange
{
    public interface IRequestReader
    {
        byte Header { get; }

        IRequest Read(byte[] bytes);
    }
}