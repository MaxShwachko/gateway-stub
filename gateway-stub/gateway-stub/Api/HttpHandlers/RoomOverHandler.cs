using System;
using System.Threading.Tasks;
using GatewayStub.Core.Exchange;
using Microsoft.AspNetCore.Http;

namespace GatewayStub.Api.HttpHandlers
{
    public class RoomOverHandler : IHttpHandler
    {
        public string Route => "over";

        public Task<int> Handle(HttpRequest request)
        {
            Console.WriteLine("RoomOverHandler handle");
            return Task.FromResult(StatusCodes.Status200OK);
        }
    }
}