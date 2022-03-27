using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
	public class HeroStatsUpdatedNotification : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.Test;
		public override byte MethodId => (byte) EMethodId.HeroStatsUpdatedNotification;

		public readonly EGatewayErrorCode ErrorCode;
		public readonly int HeroId;
		public readonly HeroStatsDto Stats;
        
		public HeroStatsUpdatedNotification(EGatewayErrorCode errorCode, int heroId, HeroStatsDto stats)
		{
			ErrorCode = errorCode;
			HeroId = heroId;
			Stats = stats;
		}
        
		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
			writer.Write(HeroId);
			Stats.NetSerialize(writer);
		}
	}
}