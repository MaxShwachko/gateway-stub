using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GatewayStub.Core.Exchange;
using Microsoft.AspNetCore.Http;

namespace GatewayStub.Core.Http.Impls
{
    public class HttpListener : IHttpListener
    {
        private readonly Dictionary<string, IHttpHandler> _handlers;

        public HttpListener(IEnumerable<IHttpHandler> handlers)
        {
            _handlers = handlers.ToDictionary(handler => handler.Route);
        }

        public async Task Listen(HttpContext ctx)
        {
            var requestPath = ctx.Request.Path;
            var pathParts = requestPath.Value.Split('/');
            var route = pathParts[3];
            var handler = _handlers[route];
            await handler.Handle(ctx.Request);
        }
    }
}