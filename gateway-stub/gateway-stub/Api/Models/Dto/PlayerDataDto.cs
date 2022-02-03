using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class PlayerDataDto : INetSerialize
    {
        public string PlayerId;
        public string Nick;
        public byte HeroId;
        public HeroStatsDto HeroStats;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(PlayerId);
            writer.Write(Nick);
            writer.Write(HeroId);
            HeroStats.NetSerialize(writer);
        }

        public void NetDeserialize(ByteReader reader)
        {
            PlayerId = reader.ReadString();
            Nick = reader.ReadString();
            HeroId = reader.ReadByte();
            HeroStats = DTOSerializer.NetDeserialize<HeroStatsDto>(reader);
        }
    }
}