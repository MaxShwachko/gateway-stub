using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Models.Dto
{
	public class BattlePassPriceDto : INetSerialize
	{
		public EBattlePassType Type;
		public string Price;

		public void NetSerialize(ByteWriter writer)
		{
			writer.Write((int) Type);
			writer.Write(Price);
		}

		public void NetDeserialize(ByteReader reader)
		{
			Type = (EBattlePassType) reader.ReadInt32();
			Price = reader.ReadString();
		}
	}
}