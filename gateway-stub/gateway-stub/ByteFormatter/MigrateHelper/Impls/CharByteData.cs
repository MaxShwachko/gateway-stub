namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(char))]
	public sealed class CharByteData : AByteData<CharByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer)
		{
			writer.Write(reader.ReadChar());
		}

		public override void Skip(ByteReader reader) => reader.SkipChar();
	}
}