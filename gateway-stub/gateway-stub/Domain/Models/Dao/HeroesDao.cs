using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;

namespace GatewayStub.Domain.Models.Dao
{
    public class HeroesDao
    {
        public NetList<AvailableHeroDto> AllHeroes;
        public NetList<HeroDto> AvailableHeroes;
        public bool EquipHeroSuccess;
        public int UndistributedExperience;
        public int ScrollsAmount;
        public int SelectedHeroUid;
    }
}