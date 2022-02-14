using System;
using System.Threading;
using System.Threading.Tasks;
using HttpContext = Microsoft.AspNetCore.Http.HttpContext;

namespace GatewayStub.Core.WebSocket.Impls
{
    public class WebSocketListener : IWebSocketListener
    {
        private readonly IWebSocketWrapper _socketWrapper;
        private readonly IWebSocketReader _socketReader;

        public WebSocketListener(IWebSocketWrapper socketWrapper, IWebSocketReader socketReader)
        {
            _socketWrapper = socketWrapper;
            _socketReader = socketReader;
        } 

        public async Task Listen(HttpContext ctx)
        {
            using var webSocket = await ctx.WebSockets.AcceptWebSocketAsync();
            _socketWrapper.Current = webSocket;
            var buffer = new byte[4096];
            var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            if (result != null)
            {
                while (!result.CloseStatus.HasValue)
                {
                    await _socketReader.ReadAsync(buffer);
                    result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                }

                await webSocket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);
            }
        }
    }
}