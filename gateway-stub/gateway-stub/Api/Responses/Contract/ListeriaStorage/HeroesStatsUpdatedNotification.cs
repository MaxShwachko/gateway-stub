using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.ListeriaStorage
{
	public class HeroesStatsUpdatedNotification : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.ListeriaStorage;
		public override byte MethodId => (byte) EMethodId.HeroesStatsUpdatedNotification;

		public readonly EGatewayErrorCode ErrorCode;
		public readonly HeroDto Hero;
        
		public HeroesStatsUpdatedNotification(EGatewayErrorCode errorCode, HeroDto hero)
		{
			ErrorCode = errorCode;
			Hero = hero;
		}
        
		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
			Hero.NetSerialize(writer);
		}
	}
}