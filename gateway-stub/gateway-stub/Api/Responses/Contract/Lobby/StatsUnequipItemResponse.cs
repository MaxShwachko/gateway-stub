using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class StatsUnequipItemResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.EquipmentEndpointsUnequipItem;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly int BindingUid;
        public readonly HeroStatsDto EquipmentBonuses;
        public readonly int SlotId;
        public readonly int HeroUid;

        public StatsUnequipItemResponse(EGatewayErrorCode errorCode, int bindingUid, HeroStatsDto equipmentBonuses, int slotId, int heroUid)
        {
            ErrorCode = errorCode;
            BindingUid = bindingUid;
            EquipmentBonuses = equipmentBonuses;
			SlotId = slotId;
			HeroUid = heroUid;
		}

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(BindingUid);
            EquipmentBonuses.NetSerialize(writer);
            writer.Write(SlotId);
            writer.Write(HeroUid);
        }
    }
}