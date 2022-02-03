namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(int?))]
	public sealed class Int32NullableByteData : AByteData<Int32NullableByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadInt32Nullable());

		public override void Skip(ByteReader reader) => reader.SkipInt32Nullable();
	}
}