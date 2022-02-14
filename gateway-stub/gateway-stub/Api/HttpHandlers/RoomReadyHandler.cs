using System.Threading.Tasks;
using GatewayStub.Core.Exchange;
using Microsoft.AspNetCore.Http;

namespace GatewayStub.Api.HttpHandlers
{
    public class RoomReadyHandler : IHttpHandler
    {
        public string Route => "ready";

        public Task Handle(HttpRequest request)
        {
            return Task.CompletedTask;
        }
    }
}