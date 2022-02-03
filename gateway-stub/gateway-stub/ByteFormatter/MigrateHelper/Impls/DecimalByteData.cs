namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(decimal))]
	public sealed class DecimalByteData : AByteData<DecimalByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadDecimal());

		public override void Skip(ByteReader reader) => reader.SkipDecimal();
	}
}