using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;

namespace GatewayStub.Domain.Models.Dao
{
    public class RegionsDao
    {
        public NetList<RegionDto> Regions;
        public string ActiveRegion;
        public bool IsFixed;
        public bool RegionSetSuccess;
    }
}