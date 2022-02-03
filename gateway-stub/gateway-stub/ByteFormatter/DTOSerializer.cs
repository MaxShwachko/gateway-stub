using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.ByteFormatter.Utils.Pools;

namespace GatewayStub.ByteFormatter
{
	public static class DTOSerializer
	{
		public static byte[] NetSerialize<T>(T dto)
			where T: INetSerialize, new()
		{
			var writer = ByteWriterPool.Instance.Get();
			dto.NetSerialize(writer);
			var bytes = writer.ToArray();
			ByteWriterPool.Instance.Return(writer);
			return bytes;
		}
		
		public static T NetDeserialize<T>(byte[] bytes)
			where T: INetSerialize, new()
		{
			var reader = ByteReaderPool.Instance.GetReader(bytes);
			var dto = NetDeserialize<T>(reader);
			ByteReaderPool.Instance.Return(reader);
			return dto;
		}		

		public static T NetDeserialize<T>(ByteReader reader)
			where T: INetSerialize, new()
		{
			var dto = new T();
			dto.NetDeserialize(reader);
			return dto;
		}
	}
}