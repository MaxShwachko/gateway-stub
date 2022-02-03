using System.Threading.Tasks;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Core.WebSocket
{
    public interface IWebSocketReader
    {
        Task<IRequest> ReadAsync(byte[] buffer);
    }
}