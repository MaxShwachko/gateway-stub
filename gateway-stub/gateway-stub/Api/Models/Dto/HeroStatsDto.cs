using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Models.Dto
{
    public class HeroStatsDto : INetSerialize
    {
        public int Strength;
        public int Agility;
        public int Intelligence;
        public EMainStat MainStat;
        public int Health;
        public string HealthRegenPercent;
        public string Armor;
        public string MoveSpeed;
        public int AttackDamage;
        public string AttackReloadSpeed;
        public int SkillPower;
        public int SkillEffectPower;
        public int UltPower;
        public int UltEffectPower;
        public string VampirismPower;

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
            Strength = reader.ReadInt32();
            Agility = reader.ReadInt32();
            Intelligence = reader.ReadInt32();
            MainStat = (EMainStat) reader.ReadByte();
            Health = reader.ReadInt32();
            HealthRegenPercent = reader.ReadString();
            Armor = reader.ReadString();
            MoveSpeed = reader.ReadString();
            AttackDamage = reader.ReadInt32();
            AttackReloadSpeed = reader.ReadString();
            SkillPower = reader.ReadInt32();
            SkillEffectPower = reader.ReadInt32();
            UltPower = reader.ReadInt32();
            UltEffectPower = reader.ReadInt32();
            VampirismPower = reader.ReadString();
        }
    }
}