namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(float[]))]
	public sealed class FloatNullableArrayByteData : AByteData<FloatNullableArrayByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadSingleNullableArray());

		public override void Skip(ByteReader reader) => reader.SkipSingleNullableArray();
	}
}