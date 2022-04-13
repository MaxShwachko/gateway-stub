using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
	public class GetBattlePassDataResponse : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.Test;
		public override byte MethodId => (byte) EMethodId.GetBattlePassData;

		public readonly EGatewayErrorCode ErrorCode;
		public readonly BattlePassProgressionDto Progression;
		public readonly NetList<UserBattlePassRewardDto> Rewards;

		public GetBattlePassDataResponse(EGatewayErrorCode errorCode, BattlePassProgressionDto progression, NetList<UserBattlePassRewardDto> rewards)
		{
			ErrorCode = errorCode;
			Progression = progression;
			Rewards = rewards;
		}

		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
			Progression.NetSerialize(writer);
			Rewards.NetSerialize(writer);
		}
	}
}