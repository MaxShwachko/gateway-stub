using System;
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
            Console.WriteLine("Path: " + requestPath);
            var handler = TryGetHandler(requestPath);
            if (handler == null)
            {
                Console.WriteLine($"Couldn't find handler for path: {requestPath}");
                return;
            }

            var statusCode = await handler.Handle(ctx.Request);
            ctx.Response.StatusCode = statusCode;
            await ctx.Response.CompleteAsync();
        }

        private IHttpHandler TryGetHandler(string route)
        {
            var pathParts = route.Split('/');
            foreach (var handler in _handlers)
                if (pathParts.Contains(handler.Key))
                    return handler.Value;
            return null;
        }
    }
}