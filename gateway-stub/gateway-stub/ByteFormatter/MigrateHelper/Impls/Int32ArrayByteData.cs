namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(int[]))]
	public sealed class Int32ArrayByteData : AByteData<Int32ArrayByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadInt32Array());

		public override void Skip(ByteReader reader) => reader.SkipInt32Array();
	}
	
	[ByteDataTypeAccess(typeof(int?[]))]
	public sealed class Int32NullableArrayByteData : AByteData<Int32ArrayByteData>
	{
		public override void Transfer(ByteReader reader, ByteWriter writer) => writer.Write(reader.ReadInt32Array());

		public override void Skip(ByteReader reader) => reader.SkipInt32Array();
	}
}