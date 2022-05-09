using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.ListeriaStorage
{
    public class HeroesHeroAddedNotification : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.ListeriaStorage;
        public override byte MethodId => (byte) EMethodId.HeroesEndpointsHeroAddedNotification;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly byte HeroId;
        public readonly string BlockId;
        public readonly string TransactionHash;
        public readonly string LinkToExplorer;
        public readonly int BindingUid;
        public readonly HeroStatsDto HeroStats;

        public HeroesHeroAddedNotification(EGatewayErrorCode errorCode, byte heroId, string blockId, string transactionHash, string linkToExplorer, int bindingUid, HeroStatsDto heroStats)
        {
            ErrorCode = errorCode;
            HeroId = heroId;
            BlockId = blockId;
            TransactionHash = transactionHash;
            LinkToExplorer = linkToExplorer;
            BindingUid = bindingUid;
            HeroStats = heroStats;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(HeroId);
            writer.Write(BlockId);
            writer.Write(TransactionHash);
            writer.Write(LinkToExplorer);
            writer.Write(BindingUid);
            HeroStats.NetSerialize(writer);
        }
    }
}