using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
	public class EquipmentEndpointsUpdatedItemNotification : AContractResponse
	{
		public override byte AgentId => (byte) EAgentId.Lobby;
		public override byte MethodId => (byte) EMethodId.EquipmentEndpointsUpdatedItemNotification;

		public readonly EGatewayErrorCode ErrorCode;
		public readonly EquipmentItemDto Item;
        
		public EquipmentEndpointsUpdatedItemNotification(EGatewayErrorCode errorCode, EquipmentItemDto item)
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