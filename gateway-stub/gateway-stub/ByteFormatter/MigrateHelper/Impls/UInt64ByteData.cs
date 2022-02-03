namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(ulong))]
	public sealed class UInt64ByteData : AByteData<UInt64ByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadUInt64());

		public override void Skip(ByteReader reader) => reader.SkipUInt64();
	}
}