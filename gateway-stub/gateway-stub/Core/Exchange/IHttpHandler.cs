using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace GatewayStub.Core.Exchange
{
    public interface IHttpHandler
    {
        string Route { get; }

        Task<int> Handle(HttpRequest request);
    }
}