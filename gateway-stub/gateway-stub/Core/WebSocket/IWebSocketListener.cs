using System.Threading.Tasks;
using HttpContext = Microsoft.AspNetCore.Http.HttpContext;

namespace GatewayStub.Core.WebSocket
{
    public interface IWebSocketListener
    {
        Task Listen(HttpContext ctx);
    }
}