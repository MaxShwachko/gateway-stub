using System.Threading.Tasks;
using GatewayStub.Core.Exchange;
using Microsoft.AspNetCore.Http;

namespace GatewayStub.Api.HttpHandlers
{
    public class RoomOverHandler : IHttpHandler
    {
        public string Route => "over";

        public Task Handle(HttpRequest request)
        {
            return Task.CompletedTask;
        }
    }
}