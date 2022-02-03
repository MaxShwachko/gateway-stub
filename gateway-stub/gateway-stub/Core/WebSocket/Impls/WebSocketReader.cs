using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GatewayStub.ByteFormatter.Utils.Pools;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Core.WebSocket.Impls
{
    public class WebSocketReader : IWebSocketReader
    {
        private readonly Dictionary<byte, IRequestReader> _readers;
        private readonly Dictionary<byte, IRequestHandler> _handlers;

        public WebSocketReader(IEnumerable<IRequestReader> readers, IEnumerable<IRequestHandler> handlers)
        {
            _readers = readers.ToDictionary(reader => reader.Header);
            _handlers = handlers.ToDictionary(handler => handler.Header);
        }

        public async Task<IRequest> ReadAsync(byte[] buffer)
        {
            var reader = ByteReaderPool.Instance.GetReader(buffer);
            var length = reader.ReadInt16();
            var header = reader.ReadByte();
            var body = reader.ReadBytes(length - 1);

            if (!_readers.ContainsKey(header))
            {
                Console.WriteLine($"No reader for message with header = {header}");
                return null;
            }

            var request = _readers[header].Read(body);

            if (request == null)
                return null;

            if (!_handlers.ContainsKey(header))
            {
                Console.WriteLine($"No handler for message with header = {header}");
                return null;
            }

            await _handlers[header].Handle(request);
            return request;
        }
    }
}