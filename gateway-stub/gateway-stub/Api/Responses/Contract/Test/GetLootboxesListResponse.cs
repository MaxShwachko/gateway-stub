using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Test
{
    public class GetLootboxesListResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Test;
        public override byte MethodId => (byte) EMethodId.GetLootboxesList;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly NetList<LootboxDto> Lootboxes;

        public GetLootboxesListResponse(EGatewayErrorCode errorCode, NetList<LootboxDto> lootboxes)
        {
            ErrorCode = errorCode;
            Lootboxes = lootboxes;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            Lootboxes.NetSerialize(writer);
        }
    }
}