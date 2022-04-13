using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Responses.Contract.Test
{
	public class UpgradeBattlePassTypeResponse : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.Test;
		public override byte MethodId => (byte) EMethodId.UpgradeBattlePassType;

		public readonly EGatewayErrorCode ErrorCode;
		public readonly EBattlePassType Type;

		public UpgradeBattlePassTypeResponse(EGatewayErrorCode errorCode, EBattlePassType type)
		{
			ErrorCode = errorCode;
			Type = type;
		}

		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
			writer.Write((int) Type);
		}
	}
}