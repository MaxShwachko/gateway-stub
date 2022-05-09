using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class StatsEquipHeroResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.HeroesEndpointsEquipHero;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly bool IsSuccess;

        public StatsEquipHeroResponse(EGatewayErrorCode errorCode, bool isSuccess)
        {
            ErrorCode = errorCode;
            IsSuccess = isSuccess;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(IsSuccess);
        }
    }
}