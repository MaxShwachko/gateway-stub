using GatewayStub.Api.Enums;
using GatewayStub.Api.Models.Dto;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Transactions
{
    public class BalanceGetListWithPaginationResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Transactions;
        public override byte MethodId => (byte) EMethodId.BalanceGetListWithPagination;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly short Page;
        public readonly short Pages;
        public readonly NetList<TransactionDto> List;

        public BalanceGetListWithPaginationResponse(EGatewayErrorCode errorCode, short page, short pages, NetList<TransactionDto> list)
        {
            ErrorCode = errorCode;
            Page = page;
            Pages = pages;
            List = list;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(Page);
            writer.Write(Pages);
            List.NetSerialize(writer);
        }
    }
}