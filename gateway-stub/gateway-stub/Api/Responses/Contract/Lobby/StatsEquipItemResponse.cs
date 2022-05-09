using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class StatsEquipItemResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.EquipmentEndpointsEquipItem;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly int BindingUid;
        public readonly int SlotUid;
        public readonly HeroStatsDto EquipmentBonuses;
        public readonly int HeroUid;

        public StatsEquipItemResponse(EGatewayErrorCode errorCode, int bindingUid, int slotUid, HeroStatsDto equipmentBonuses, int heroUid)
        {
            ErrorCode = errorCode;
            BindingUid = bindingUid;
            SlotUid = slotUid;
            EquipmentBonuses = equipmentBonuses;
            HeroUid = heroUid;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(BindingUid);
            writer.Write(SlotUid);
            EquipmentBonuses.NetSerialize(writer);
            writer.Write(HeroUid);
        }
    }
}