using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
	public class GetBattlePassPricesResponse : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.Test;
		public override byte MethodId => (byte) EMethodId.GetBattlePassPrices;
		
		public readonly EGatewayErrorCode ErrorCode;
		public readonly BattlePassPricesDto Prices;

		public GetBattlePassPricesResponse(EGatewayErrorCode errorCode, BattlePassPricesDto prices)
		{
			ErrorCode = errorCode;
			Prices = prices;
		}

		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
			Prices.NetSerialize(writer);
		}
	}
}