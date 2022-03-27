using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
    public class HeroesGiveFreeExperienceToHeroResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.ListeriaStorage;
        public override byte MethodId => (byte) EMethodId.HeroesGiveFreeExperienceToHero;

        public readonly EGatewayErrorCode ErrorCode;

        public HeroesGiveFreeExperienceToHeroResponse(EGatewayErrorCode errorCode)
        {
            ErrorCode = errorCode;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
        }
    }
}