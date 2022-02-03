namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(ushort))]
	public sealed class UInt16ByteData : AByteData<UInt16ByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadUInt16());

		public override void Skip(ByteReader reader) => reader.SkipUInt16();
	}
}