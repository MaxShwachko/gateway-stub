using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Models.Dto
{
	public class ItemDto : INetSerialize
	{
		public EProductType Type;
		public int Amount;
		public int ItemId;

		public void NetSerialize(ByteWriter writer)
		{
			writer.Write((int) Type);
			writer.Write(Amount);
			writer.Write(ItemId);
		}

		public void NetDeserialize(ByteReader reader)
		{
			Type = (EProductType) reader.ReadInt32();
			Amount = reader.ReadInt32();
			ItemId = reader.ReadInt32();
		}
	}
}