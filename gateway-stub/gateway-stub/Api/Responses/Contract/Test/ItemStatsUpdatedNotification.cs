using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
	public class ItemStatsUpdatedNotification : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.Test;
		public override byte MethodId => (byte) EMethodId.ItemStatsUpdatedNotification;

		public readonly EGatewayErrorCode ErrorCode;
		public readonly EquipmentItemDto Item;
        
		public ItemStatsUpdatedNotification(EGatewayErrorCode errorCode, EquipmentItemDto item)
		{
			ErrorCode = errorCode;
			Item = item;
		}
        
		protected override void WriteBody(ByteWriter writer)
		{
			writer.Write((int) ErrorCode);
			Item.NetSerialize(writer);
		}
	}
}