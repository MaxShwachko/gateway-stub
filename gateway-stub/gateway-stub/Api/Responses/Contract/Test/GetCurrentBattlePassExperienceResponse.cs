using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
	public class GetCurrentBattlePassExperienceResponse : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.Test;
		public override byte MethodId => (byte) EMethodId.GetCurrentBattlePassExperience;

		public readonly EGatewayErrorCode ErrorCode;
		public readonly int Amount;

		public GetCurrentBattlePassExperienceResponse(EGatewayErrorCode errorCode, int amount)
		{
			ErrorCode = errorCode;
			Amount = amount;
		}

		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
			writer.Write(Amount);
		}
	}
}