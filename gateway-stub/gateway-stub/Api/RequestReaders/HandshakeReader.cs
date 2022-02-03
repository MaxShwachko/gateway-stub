using System;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests;
using GatewayStub.ByteFormatter.Utils.Pools;
using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders
{
    public class HandshakeReader : IRequestReader
    {
        public byte Header => (byte) EHeader.Handshake;

        public IRequest Read(byte[] bytes)
        {
            var reader = ByteReaderPool.Instance.GetReader(bytes);
            var authToken = reader.ReadString();
            var apiVersion = reader.ReadString();
            // var sessionToken = reader.ReadString();
            ByteReaderPool.Instance.Return(reader);
            return new HandshakeRequest(authToken, apiVersion, string.Empty);
        }
    }
}