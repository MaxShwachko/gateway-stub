using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Purchase
{
    public class WalletGetByUserIdResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Purchase;
        public override byte MethodId => (byte) EMethodId.WalletGetByUserId;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly string Address;

        public WalletGetByUserIdResponse(EGatewayErrorCode errorCode, string address)
        {
            ErrorCode = errorCode;
            Address = address;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(Address);
        }
    }
}