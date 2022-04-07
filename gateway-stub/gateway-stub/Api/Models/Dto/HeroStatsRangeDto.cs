using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Models.Dto
{
    public class HeroStatsRangeDto : INetSerialize
    {
		public EMainStat MainStat;
        public string[] Strength;
        public string[] Agility;
        public string[] Intelligence;
        public string[] Health;
        public string[] HealthRegenPercent;
        public string[] Armor;
        public string[] MoveSpeed;
        public string[] AttackDamage;
        public string[] AttackReloadSpeed;
        public string[] SkillPower;
        public string[] SkillEffectPower;
        public string[] UltPower;
        public string[] UltEffectPower;
        public string[] VampirismPower;

        public void NetSerialize(ByteWriter writer)
        {
			writer.Write((byte) MainStat);
            writer.Write(Strength);
            writer.Write(Agility);
            writer.Write(Intelligence);
            writer.Write(Health);
            writer.Write(HealthRegenPercent);
            writer.Write(Armor);
            writer.Write(MoveSpeed);
            writer.Write(AttackDamage);
            writer.Write(AttackReloadSpeed);
            writer.Write(SkillPower);
            writer.Write(SkillEffectPower);
            writer.Write(UltPower);
            writer.Write(UltEffectPower);
            writer.Write(VampirismPower);
        }

        public void NetDeserialize(ByteReader reader)
        {
			MainStat = (EMainStat) reader.ReadByte();
            Strength = reader.ReadStringArray();
            Agility = reader.ReadStringArray();
            Intelligence = reader.ReadStringArray();
            Health = reader.ReadStringArray();
            HealthRegenPercent = reader.ReadStringArray();
            Armor = reader.ReadStringArray();
            MoveSpeed = reader.ReadStringArray();
            AttackDamage = reader.ReadStringArray();
            AttackReloadSpeed = reader.ReadStringArray();
            SkillPower = reader.ReadStringArray();
            SkillEffectPower = reader.ReadStringArray();
            UltPower = reader.ReadStringArray();
            UltEffectPower = reader.ReadStringArray();
            VampirismPower = reader.ReadStringArray();
        }
    }
}