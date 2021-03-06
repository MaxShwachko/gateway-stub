namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(short?))]
	public sealed class Int16NullableByteData : AByteData<Int16NullableByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadInt16Nullable());

		public override void Skip(ByteReader reader) => reader.SkipInt16Nullable();
	}
}