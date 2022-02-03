using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Utils.Pools;

namespace GatewayStub.Core.Exchange
{
    public abstract class AContractResponse : IResponse
    {
        public byte GetHeader() => (byte) EHeader.Contract;
        public abstract byte AgentId { get; }
        public abstract byte MethodId { get; }

        public void Write(ByteWriter writer)
        {
            writer.Write(0L);           //this fields is useless for now, maybe need to remove
            writer.Write("0.1.0");      //this fields is useless for now, maybe need to remove
            writer.Write(MethodId);
            writer.Write(AgentId);
            var innerWriter = ByteWriterPool.Instance.Get();
            WriteBody(innerWriter);
            var body = innerWriter.ToArray();
            writer.WriteBytesAndSize(body, body.Length);
            ByteWriterPool.Instance.Return(innerWriter);
        }

        protected abstract void WriteBody(ByteWriter writer);
    }
}