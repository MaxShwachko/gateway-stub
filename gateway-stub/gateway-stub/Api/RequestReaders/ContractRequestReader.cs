using System;
using System.Collections.Generic;
using System.Linq;
using GatewayStub.Api.Enums;
using GatewayStub.Api.Requests;
using GatewayStub.ByteFormatter.Utils.Pools;
using GatewayStub.Core;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.RequestReaders
{
    public class ContractRequestReader : IRequestReader
    {
        private readonly Dictionary<Tuple<byte,byte>,IContractRequestReader> _requestReaders;
        public byte Header => (byte) EHeader.Contract;

        public ContractRequestReader(IEnumerable<IContractRequestReader> requestReaders)
        {
            _requestReaders = requestReaders.ToDictionary(reader => new Tuple<byte, byte>(reader.AgentId, reader.MethodId));
        }

        public IRequest Read(byte[] bytes)
        {
            var reader = ByteReaderPool.Instance.GetReader(bytes);
            var id = reader.ReadInt64();
            // var api = reader.ReadString();
            var methodId = reader.ReadByte();
            var agentId = reader.ReadByte();
            var methodBytes = reader.ReadBytesAndSize();
            var key = new Tuple<byte, byte>(agentId, methodId);
            if (!_requestReaders.ContainsKey(key))
            {
                Console.WriteLine($"No contract request reader for contract message with agentId = {agentId} and methodId = {methodId}");
                return null;
            }

            var requestReader = _requestReaders[new Tuple<byte, byte>(agentId, methodId)];
            var dataReader = ByteReaderPool.Instance.GetReader(methodBytes);
            var result = requestReader.ReadRequest(dataReader);
            ByteReaderPool.Instance.Return(reader);
            ByteReaderPool.Instance.Return(dataReader);
            return new ContractRequest(id, agentId, methodId, result);
        }
    }
}