using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Models.Dto
{
    public class HeroStatsRangeDto : INetSerialize
    {
        public int[] Strength;
        public int[] Agility;
        public int[] Intelligence;
        public EMainStat MainStat;
        public int[] Health;
        public string[] HealthRegenPercent;
        public string[] Armor;
        public string[] MoveSpeed;
        public int[] AttackDamage;
        public string[] AttackReloadSpeed;
        public int[] SkillPower;
        public int[] SkillEffectPower;
        public int[] UltPower;
        public int[] UltEffectPower;
        public string[] VampirismPower;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(Strength);
            writer.Write(Agility);
            writer.Write(Intelligence);
            writer.Write((byte) MainStat);
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
            Strength = reader.ReadInt32Array();
            Agility = reader.ReadInt32Array();
            Intelligence = reader.ReadInt32Array();
            MainStat = (EMainStat) reader.ReadByte();
            Health = reader.ReadInt32Array();
            HealthRegenPercent = reader.ReadStringArray();
            Armor = reader.ReadStringArray();
            MoveSpeed = reader.ReadStringArray();
            AttackDamage = reader.ReadInt32Array();
            AttackReloadSpeed = reader.ReadStringArray();
            SkillPower = reader.ReadInt32Array();
            SkillEffectPower = reader.ReadInt32Array();
            UltPower = reader.ReadInt32Array();
            UltEffectPower = reader.ReadInt32Array();
            VampirismPower = reader.ReadStringArray();
        }
    }
}