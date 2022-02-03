using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;

namespace GatewayStub.Domain.Models.Dao
{
    public class HeroesDao
    {
        public NetList<HeroDto> AvailableHeroes;
        public bool EquipHeroSuccess;
    }
}