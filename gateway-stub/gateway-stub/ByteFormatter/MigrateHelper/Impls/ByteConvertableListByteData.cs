using System.Collections.Generic;
using GatewayStub.ByteFormatter.StateSerialize;

namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	[ByteDataTypeAccess(typeof(IList<IByteConvertable>))]
	public sealed class ByteConvertableListByteData<T> : AByteData<ByteConvertableListByteData<T>>
		where T : IByteData, new()
	{
		private static readonly T ByteData = new T();

		public override void Transfer(ByteReader reader, ByteWriter writer)
		{
			var length = reader.ReadInt32();
			writer.Write(length);
			for (var i = 0; i < length; i++)
			{
				ByteData.Transfer(reader, writer);
			}
		}

		public override void Skip(ByteReader reader)
		{
			var length = reader.ReadInt32();
			for (var i = 0; i < length; i++)
			{
				ByteData.Skip(reader);
			}
		}
	}
}