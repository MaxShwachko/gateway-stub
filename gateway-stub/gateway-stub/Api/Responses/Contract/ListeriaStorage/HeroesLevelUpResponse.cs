using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.ListeriaStorage
{
    public class HeroesLevelUpResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.ListeriaStorage;
        public override byte MethodId => (byte) EMethodId.HeroesLevelUp;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly bool IsSuccess;

        public HeroesLevelUpResponse(EGatewayErrorCode errorCode, bool isSuccess)
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