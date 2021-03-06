using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Models.Dto
{
    public class HeroStatsDto : INetSerialize
    {
        public string Strength;
        public string Agility;
        public string Intelligence;
        public EMainStat MainStat;
        public string Health;
        public string HealthRegenPercent;
        public string Armor;
        public string MoveSpeed;
        public string AttackDamage;
        public string AttackReloadSpeed;
        public string SkillPower;
        public string SkillEffectPower;
        public string UltPower;
        public string UltEffectPower;
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
            Strength = reader.ReadString();
            Agility = reader.ReadString();
            Intelligence = reader.ReadString();
            MainStat = (EMainStat) reader.ReadByte();
            Health = reader.ReadString();
            HealthRegenPercent = reader.ReadString();
            Armor = reader.ReadString();
            MoveSpeed = reader.ReadString();
            AttackDamage = reader.ReadString();
            AttackReloadSpeed = reader.ReadString();
            SkillPower = reader.ReadString();
            SkillEffectPower = reader.ReadString();
            UltPower = reader.ReadString();
            UltEffectPower = reader.ReadString();
            VampirismPower = reader.ReadString();
        }
    }
}