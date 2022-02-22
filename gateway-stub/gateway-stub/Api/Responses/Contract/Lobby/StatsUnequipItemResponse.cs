using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class StatsUnequipItemResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.StatsUnequipItem;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly int BindingUid;
        public readonly HeroStatsDto EquipmentBonuses;
        public readonly int SlotUid;

        public StatsUnequipItemResponse(EGatewayErrorCode errorCode, int bindingUid, HeroStatsDto equipmentBonuses, int slotUid)
        {
            ErrorCode = errorCode;
            BindingUid = bindingUid;
            EquipmentBonuses = equipmentBonuses;
            SlotUid = slotUid;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(BindingUid);
            EquipmentBonuses.NetSerialize(writer);
            writer.Write(SlotUid);
        }
    }
}