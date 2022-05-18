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
        public readonly int HeroUid;
        public readonly int SlotId;

        public StatsUnequipItemResponse(EGatewayErrorCode errorCode, int bindingUid, HeroStatsDto equipmentBonuses, int heroUid, int slotId)
        {
            ErrorCode = errorCode;
            BindingUid = bindingUid;
            HeroUid = heroUid;
            SlotId = slotId;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(BindingUid);
            writer.Write(HeroUid);
            writer.Write(SlotId);
        }
    }
}