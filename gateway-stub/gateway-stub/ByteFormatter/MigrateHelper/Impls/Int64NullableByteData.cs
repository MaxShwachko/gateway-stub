namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(long?))]
	public sealed class Int64NullableByteData : AByteData<Int64NullableByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer)
			=> writer.Write(reader.ReadInt64Nullable());

		public override void Skip(ByteReader reader) => reader.SkipInt64Nullable();
	}
}