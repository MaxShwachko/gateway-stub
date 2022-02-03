using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Auth
{
    public class AuthAssignProviderAccountToDeviceIdResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Auth;
        public override byte MethodId => (byte) EMethodId.AuthAssignProviderAccountToDeviceId;

        public readonly EGatewayErrorCode ErrorCode;
        public readonly bool IsSuccess;

        public AuthAssignProviderAccountToDeviceIdResponse(EGatewayErrorCode errorCode, bool isSuccess)
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