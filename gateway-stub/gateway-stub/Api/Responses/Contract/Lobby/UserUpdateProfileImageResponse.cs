using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class UserUpdateProfileImageResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.UserUpdateProfileImage;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly bool IsSuccess;
        public readonly byte Image;

        public UserUpdateProfileImageResponse(EGatewayErrorCode errorCode, bool isSuccess, byte image)
        {
            ErrorCode = errorCode;
            IsSuccess = isSuccess;
            Image = image;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(IsSuccess);
            writer.Write(Image);
        }
    }
}