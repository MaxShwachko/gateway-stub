using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace GatewayStub.Core.Exchange
{
    public interface IHttpHandler
    {
        string Route { get; }

        Task Handle(HttpRequest request);
    }
}