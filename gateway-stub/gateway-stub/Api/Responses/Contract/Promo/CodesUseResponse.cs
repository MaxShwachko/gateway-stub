using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Promo
{
    public class CodesUseResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Promo;
        public override byte MethodId => (byte) EMethodId.CodesUse;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<PromoRewardDto> Rewards;

        public CodesUseResponse(EGatewayErrorCode errorCode, NetList<PromoRewardDto> rewards)
        {
            ErrorCode = errorCode;
            Rewards = rewards;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            Rewards.NetSerialize(writer);
        }
    }
}