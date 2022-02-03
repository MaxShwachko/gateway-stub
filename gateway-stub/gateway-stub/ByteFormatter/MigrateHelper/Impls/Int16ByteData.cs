namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(short))]
	public sealed class Int16ByteData : AByteData<Int16ByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadInt16());

		public override void Skip(ByteReader reader) => reader.SkipInt16();
	}
}