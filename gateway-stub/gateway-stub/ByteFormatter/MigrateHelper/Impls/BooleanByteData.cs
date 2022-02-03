namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(bool))]
	public sealed class BooleanByteData : AByteData<BooleanByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer)
		{
			writer.Write(reader.ReadBoolean());
		}

		public override void Skip(ByteReader reader) => reader.SkipBoolean();
	}
}