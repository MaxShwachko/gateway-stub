namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(sbyte?))]
	public sealed class SByteNullableByteData : AByteData<SByteNullableByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer)
			=> writer.Write(reader.ReadSByteNullable());

		public override void Skip(ByteReader reader) => reader.SkipSByteNullable();
	}
}