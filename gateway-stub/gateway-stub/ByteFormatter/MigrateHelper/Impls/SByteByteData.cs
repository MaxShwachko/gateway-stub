namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(sbyte))]
	public sealed class SByteByteData : AByteData<SByteByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) 
			=> writer.Write(reader.ReadSByte());

		public override void Skip(ByteReader reader) => reader.SkipSByte();
	}
}