using System.Threading.Tasks;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Core.WebSocket
{
    public interface IWebSocketWrapper
    {
        System.Net.WebSockets.WebSocket Current { get; set; }
        Task Send(IResponse response);
    }
}