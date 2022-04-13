using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
	public class BattlePassExperienceUpdatedNotification : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.Test;
		public override byte MethodId => (byte) EMethodId.BattlePassExperienceUpdatedNotification;

		public readonly EGatewayErrorCode ErrorCode;
		public readonly int Balance;
        
		public BattlePassExperienceUpdatedNotification(EGatewayErrorCode errorCode, int balance)
		{
			ErrorCode = errorCode;
			Balance = balance;
		}

		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
			writer.Write(Balance);
		}
	}
}