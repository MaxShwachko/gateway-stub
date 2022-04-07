using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
	public class ItemLevelUpResponse : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.Test;
		public override byte MethodId => (byte) EMethodId.ItemLevelUp;

		public readonly EGatewayErrorCode ErrorCode;
		public readonly bool IsSuccess;

		public ItemLevelUpResponse(EGatewayErrorCode errorCode, bool isSuccess)
		{
			ErrorCode = errorCode;
			IsSuccess = isSuccess;
		}

		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
			writer.Write(IsSuccess);
		}
	}
}