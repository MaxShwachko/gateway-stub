namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(uint?))]
	public sealed class UInt32NullableByteData : AByteData<UInt32NullableByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadUInt32Nullable());

		public override void Skip(ByteReader reader) => reader.SkipUInt32Nullable();
	}
}