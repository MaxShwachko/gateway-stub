namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(ulong?))]
	public sealed class UInt64NullableByteData : AByteData<UInt64NullableByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer)
			=> writer.Write(reader.ReadUInt64Nullable());

		public override void Skip(ByteReader reader) => reader.SkipUInt64Nullable();
	}
}