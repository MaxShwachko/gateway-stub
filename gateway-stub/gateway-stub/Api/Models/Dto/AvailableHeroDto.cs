using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class AvailableHeroDto : INetSerialize
    {
        public byte HeroId;
        public HeroStatsRangeDto Stats;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(HeroId);
            Stats.NetSerialize(writer);
        }

        public void NetDeserialize(ByteReader reader)
        {
            HeroId = reader.ReadByte();
            Stats = DTOSerializer.NetDeserialize<HeroStatsRangeDto>(reader);
        }
    }
}