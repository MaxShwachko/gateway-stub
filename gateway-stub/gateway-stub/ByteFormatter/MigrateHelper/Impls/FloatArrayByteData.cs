namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(float[]))]
	public sealed class FloatArrayByteData : AByteData<FloatArrayByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadSingleArray());

		public override void Skip(ByteReader reader) => reader.SkipSingleArray();
	}
}