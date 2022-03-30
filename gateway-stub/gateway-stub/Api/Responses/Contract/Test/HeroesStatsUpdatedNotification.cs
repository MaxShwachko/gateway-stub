using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
	public class HeroesStatsUpdatedNotification : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.ListeriaStorage;
		public override byte MethodId => (byte) EMethodId.HeroesStatsUpdatedNotification;

		public readonly EGatewayErrorCode ErrorCode;
		public readonly int HeroId;
		public readonly HeroStatsDto Stats;
        
		public HeroesStatsUpdatedNotification(EGatewayErrorCode errorCode, int heroId, HeroStatsDto stats)
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