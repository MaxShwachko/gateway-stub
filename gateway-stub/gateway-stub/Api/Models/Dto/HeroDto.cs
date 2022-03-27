using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class HeroDto : INetSerialize
    {
        public byte HeroId;
        public short Level;
        public int Experience;
        public bool IsActive;
        public string TransactionHash;
        public int BindingUid;
        public string LinkToExplorer;
        public HeroStatsDto HeroStats;
        public HeroStatsDto EquipmentBonuses;
        public NetList<SlotDto> Slots;
        public string BlockId;
        public bool IsPending;
		public int LevelupExperienceCost;
		public int LevelupScrollsCost;
		public short MaxLevel;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(HeroId);
            writer.Write(Level);
            writer.Write(Experience);
            writer.Write(IsActive);
            writer.Write(TransactionHash);
            writer.Write(BindingUid);
            writer.Write(LinkToExplorer);
            HeroStats.NetSerialize(writer);
            EquipmentBonuses.NetSerialize(writer);
            Slots.NetSerialize(writer);
            writer.Write(BlockId);
            writer.Write(IsPending);
			writer.Write(LevelupExperienceCost);
			writer.Write(LevelupScrollsCost);
			writer.Write(MaxLevel);
        }

        public void NetDeserialize(ByteReader reader)
        {
            HeroId = reader.ReadByte();
            Level = reader.ReadInt16();
            Experience = reader.ReadInt32();
            IsActive = reader.ReadBoolean();
            TransactionHash = reader.ReadString();
            BindingUid = reader.ReadInt32();
            LinkToExplorer = reader.ReadString();
            HeroStats = DTOSerializer.NetDeserialize<HeroStatsDto>(reader);
            EquipmentBonuses = DTOSerializer.NetDeserialize<HeroStatsDto>(reader);
            Slots = DTOSerializer.NetDeserialize<NetList<SlotDto>>(reader);
            BlockId = reader.ReadString();
            IsPending = reader.ReadBoolean();
			LevelupExperienceCost = reader.ReadInt32();
			LevelupScrollsCost = reader.ReadInt32();
			MaxLevel = reader.ReadInt16();
        }
    }
}