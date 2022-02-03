namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(int))]
	public sealed class Int32ByteData : AByteData<Int32ByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadInt32());

		public override void Skip(ByteReader reader) => reader.SkipInt32();
	}
}