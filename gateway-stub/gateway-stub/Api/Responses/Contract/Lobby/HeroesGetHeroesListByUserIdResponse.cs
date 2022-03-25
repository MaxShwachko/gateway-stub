using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class HeroesGetHeroesListByUserIdResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.ListeriaStorage;
        public override byte MethodId => (byte) EMethodId.HeroesGetHeroesListByUserId;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<HeroDto> AvailableHeroes;

        public HeroesGetHeroesListByUserIdResponse(EGatewayErrorCode errorCode, NetList<HeroDto> availableHeroes)
        {
            ErrorCode = errorCode;
            AvailableHeroes = availableHeroes;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            AvailableHeroes.NetSerialize(writer);
        }
    }
}