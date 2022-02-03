using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class GetRegionsResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.GetRegions;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly string Active;
        public readonly bool IsFixed;
        public readonly NetList<RegionDto> List;

        public GetRegionsResponse(EGatewayErrorCode errorCode, string active, bool isFixed, NetList<RegionDto> list)
        {
            ErrorCode = errorCode;
            Active = active;
            IsFixed = isFixed;
            List = list;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(Active);
            writer.Write(IsFixed);
            List.NetSerialize(writer);
        }
    }
}