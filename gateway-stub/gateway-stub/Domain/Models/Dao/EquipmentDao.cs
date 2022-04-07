using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;

namespace GatewayStub.Domain.Models.Dao
{
    public class EquipmentDao
    {
        public NetList<EquipmentItemDto> Equipment;
        public int EquippedItemBindingUid;
        public int EquippedItemSlotUid;
        public int EquippedItemHeroUid;
        public HeroStatsDto EquipmentBonuses;
		public int ItemScrollsAmount;
    }
}