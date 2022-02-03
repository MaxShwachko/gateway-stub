namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(byte))]
	public sealed class ByteByteData : AByteData<ByteByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer)
		{
			writer.Write(reader.ReadByte());
		}

		public override void Skip(ByteReader reader) => reader.SkipByte();
	}
}