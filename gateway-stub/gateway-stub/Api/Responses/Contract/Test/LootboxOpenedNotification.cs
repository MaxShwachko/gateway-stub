using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
    public class LootboxOpenedNotification : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Test;
        public override byte MethodId => (byte) EMethodId.GetLootboxesList;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<LootboxRewardDto> Rewards;

        public LootboxOpenedNotification(EGatewayErrorCode errorCode, NetList<LootboxRewardDto> rewards)
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