using System.Collections.Generic;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.ByteFormatter
{
	public class NetList<T> : List<T>, INetSerialize where T : INetSerialize, new()
	{
		public void NetSerialize(ByteWriter writer)
		{
			writer.Write((short) Count);
			foreach (var v in this)
				v.NetSerialize(writer);
		}

		public void NetDeserialize(ByteReader reader)
		{
			var count = reader.ReadInt16();
			for (int i = 0; i < count; i++)
			{
				var data = new T();
				data.NetDeserialize(reader);
				Add(data);
			}
		}
	}
}