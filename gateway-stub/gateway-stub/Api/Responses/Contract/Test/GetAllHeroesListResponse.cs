using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
    public class GetAllHeroesListResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Test;
        public override byte MethodId => (byte) EMethodId.GetAllHeroesList;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<AvailableHeroDto> Heroes;

        public GetAllHeroesListResponse(EGatewayErrorCode errorCode, NetList<AvailableHeroDto> heroes)
        {
            ErrorCode = errorCode;
            Heroes = heroes;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            Heroes.NetSerialize(writer);
        }
    }
}