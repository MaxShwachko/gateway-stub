using System.Threading.Tasks;
using HttpContext = Microsoft.AspNetCore.Http.HttpContext;

namespace GatewayStub.Core.Http
{
    public interface IHttpListener
    {
        Task Listen(HttpContext ctx);
    }
}