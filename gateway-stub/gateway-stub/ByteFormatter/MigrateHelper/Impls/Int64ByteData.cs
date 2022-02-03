namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(long))]
	public sealed class Int64ByteData : AByteData<Int64ByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadInt64());

		public override void Skip(ByteReader reader) => reader.SkipInt64();
	}
}