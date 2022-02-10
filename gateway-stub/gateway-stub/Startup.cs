using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading;
using GatewayStub.Configuration;
using GatewayStub.Core;
using GatewayStub.Core.WebSocket;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GatewayStub
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureDependencies();
            // services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IWebSocketReader socketReader, IWebSocketWrapper socketWrapper)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var webSocketOptions = new WebSocketOptions { KeepAliveInterval = TimeSpan.FromSeconds(60) };
            app.UseWebSockets(webSocketOptions);
            // app.UseRouting();

            app.Use(async (ctx, next) =>
            {
                if (ctx.WebSockets.IsWebSocketRequest)
                {
                    Console.WriteLine("Got websocket request");
                    using var webSocket = await ctx.WebSockets.AcceptWebSocketAsync();
                    socketWrapper.Current = webSocket;
                    var buffer = new byte[4096];
                    var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    if (result != null)
                    {
                        while (!result.CloseStatus.HasValue)
                        {
                            await socketReader.ReadAsync(buffer);
                            result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                        }

                        await webSocket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);
                    }
                }
                else
                {
                    Console.WriteLine("Got non websocket request");
                    ctx.Response.StatusCode = (int) HttpStatusCode.BadRequest;
                }
            });
        }
    }
}