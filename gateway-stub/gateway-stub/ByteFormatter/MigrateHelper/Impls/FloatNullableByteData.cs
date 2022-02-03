namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(float?))]
	public sealed class FloatNullableByteData : AByteData<FloatNullableByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer)
			=> writer.Write(reader.ReadSingleNullable());

		public override void Skip(ByteReader reader) => reader.SkipSingleNullable();
	}
}