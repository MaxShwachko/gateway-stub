using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
    public class LevelupHeroResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Test;
        public override byte MethodId => (byte) EMethodId.LevelupHero;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly HeroDto Hero;

        public LevelupHeroResponse(EGatewayErrorCode errorCode, HeroDto hero)
        {
            ErrorCode = errorCode;
            Hero = hero;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            Hero.NetSerialize(writer);
        }
    }
}