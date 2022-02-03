namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(ushort?))]
	public sealed class UInt16NullableByteData : AByteData<UInt16NullableByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadUInt16Nullable());

		public override void Skip(ByteReader reader) => reader.SkipUInt16Nullable();
	}
}