using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
	public class BattlePassPricesDto : INetSerialize
	{
		public string ExperiencePrice;
		public NetList<BattlePassPriceDto> Prices;

		public void NetSerialize(ByteWriter writer)
		{
			writer.Write(ExperiencePrice);
			Prices.NetSerialize(writer);
		}

		public void NetDeserialize(ByteReader reader)
		{
			ExperiencePrice = reader.ReadString();
			Prices = DTOSerializer.NetDeserialize<NetList<BattlePassPriceDto>>(reader);
		}
	}
}