using GatewayStub.ByteFormatter.StateSerialize;

namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(IByteConvertable))]
	public sealed class ByteConvertableByteData<T> : AByteData<ByteConvertableByteData<T>>
		where T : IByteData, new()
	{
		private static readonly T ByteData = new T();

		public override void Transfer(ByteReader reader, ByteWriter writer) => ByteData.Transfer(reader, writer);

		public override void Skip(ByteReader reader) => ByteData.Skip(reader);
	}
}