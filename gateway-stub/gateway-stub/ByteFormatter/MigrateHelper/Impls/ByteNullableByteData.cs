namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(byte?))]
	public sealed class ByteNullableByteData : AByteData<ByteNullableByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer)
		{
			writer.Write(reader.ReadByteNullable());
		}

		public override void Skip(ByteReader reader) => reader.SkipByteNullable();
	}
}