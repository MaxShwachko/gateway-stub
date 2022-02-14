using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading;
using GatewayStub.Configuration;
using GatewayStub.Core;
using GatewayStub.Core.Http;
using GatewayStub.Core.WebSocket;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GatewayStub
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureDependencies();
            // services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IWebSocketListener webSocketListener, IHttpListener httpListener)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var webSocketOptions = new WebSocketOptions { KeepAliveInterval = TimeSpan.FromSeconds(60) };
            app.UseWebSockets(webSocketOptions);
            // app.UseRouting();
            // app.UseMvc();

            app.Use(async (ctx, next) =>
            {
                if (ctx.WebSockets.IsWebSocketRequest)
                {
                    Console.WriteLine("Got websocket request");
                    await webSocketListener.Listen(ctx);
                }
                else
                {
                    Console.WriteLine("Got non websocket request");
                    await httpListener.Listen(ctx);
                }
            });
        }
    }
}