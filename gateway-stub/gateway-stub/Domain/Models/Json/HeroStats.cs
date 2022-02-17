using System;
using GatewayStub.Api.Models.Dto;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Domain.Models.Json
{
    [Serializable]
    public class HeroStats
    {
        public int strength;
        public int agility;
        public int intelligence;
        public EMainStat mainStat;
        public int health;
        public string healthRegenPercent;
        public string armor;
        public string moveSpeed;
        public int attackDamage;
        public string attackReloadSpeed;
        public int skillPower;
        public int skillEffectPower;
        public int ultPower;
        public int ultEffectPower;
        public string vampirismPower;

        public static HeroStats FromDto(HeroStatsDto heroStatsDto)  //TODO : remove after AutoMapper adding
        {
            return new HeroStats
            {
                strength = heroStatsDto.Strength,
                agility = heroStatsDto.Agility,
                intelligence = heroStatsDto.Intelligence,
                mainStat = heroStatsDto.MainStat,
                health = heroStatsDto.Health,
                healthRegenPercent = heroStatsDto.HealthRegenPercent,
                armor = heroStatsDto.Armor,
                moveSpeed = heroStatsDto.MoveSpeed,
                attackDamage = heroStatsDto.AttackDamage,
                attackReloadSpeed = heroStatsDto.AttackReloadSpeed,
                skillPower = heroStatsDto.SkillPower,
                skillEffectPower = heroStatsDto.SkillEffectPower,
                ultPower = heroStatsDto.UltPower,
                ultEffectPower = heroStatsDto.UltEffectPower,
                vampirismPower = heroStatsDto.VampirismPower,
            };
        }
    }
}