using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.ListeriaStorage
{
	public class ItemLevelUpResponse : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.ListeriaStorage;
		public override byte MethodId => (byte) EMethodId.InventoryEndpointsLevelUp;

		public readonly EGatewayErrorCode ErrorCode;

		public ItemLevelUpResponse(EGatewayErrorCode errorCode)
		{
			ErrorCode = errorCode;
		}

		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
		}
	}
}