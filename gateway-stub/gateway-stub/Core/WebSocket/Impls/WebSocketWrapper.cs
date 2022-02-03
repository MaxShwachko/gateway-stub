using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using GatewayStub.ByteFormatter.Utils;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Core.WebSocket.Impls
{
    public class WebSocketWrapper : IWebSocketWrapper, IDisposable
    {
        private System.Net.WebSockets.WebSocket _current;

        public System.Net.WebSockets.WebSocket Current
        {
            get
            {
                if (_current != null)
                {
                    return _current;
                }
                else
                {
                    Console.WriteLine("Socket connection is closed");
                    return null;
                }
            }
            set => _current = value;
        }

        public async Task Send(IResponse response)
        {
            var bytes = response.GetRequestBytes();
            await _current.SendAsync(bytes, WebSocketMessageType.Binary, true, CancellationToken.None);
        }

        public void Dispose() => _current?.Dispose();
    }
}