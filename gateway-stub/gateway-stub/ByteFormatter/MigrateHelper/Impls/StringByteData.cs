namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(string))]
	public sealed class StringByteData : AByteData<StringByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadString());

		public override void Skip(ByteReader reader) => reader.SkipString();
	}
}