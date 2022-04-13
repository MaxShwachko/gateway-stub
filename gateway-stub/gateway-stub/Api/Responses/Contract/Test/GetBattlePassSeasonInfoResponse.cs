using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
	public class GetBattlePassSeasonInfoResponse : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.Test;
		public override byte MethodId => (byte) EMethodId.GetBattlePassSeasonInfo;
		
		public readonly EGatewayErrorCode ErrorCode;
		public readonly BattlePassSeasonDto Season;

		public GetBattlePassSeasonInfoResponse(EGatewayErrorCode errorCode, BattlePassSeasonDto season)
		{
			ErrorCode = errorCode;
			Season = season;
		}

		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
			Season.NetSerialize(writer);
		}
	}
}