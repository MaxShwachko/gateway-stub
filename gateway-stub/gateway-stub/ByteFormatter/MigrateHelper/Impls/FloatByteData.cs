namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(float))]
	public sealed class FloatByteData : AByteData<FloatByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadSingle());

		public override void Skip(ByteReader reader) => reader.SkipSingle();
	}
}