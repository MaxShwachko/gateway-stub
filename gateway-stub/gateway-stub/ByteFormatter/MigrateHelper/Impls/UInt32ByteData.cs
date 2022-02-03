namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(uint))]
	public sealed class UInt32ByteData : AByteData<UInt32ByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadUInt32());

		public override void Skip(ByteReader reader) => reader.SkipUInt32();
	}
}