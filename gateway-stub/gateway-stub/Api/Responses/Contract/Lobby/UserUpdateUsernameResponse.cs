using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class UserUpdateUsernameResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.UserUpdateUsername;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly bool IsSuccess;
        public readonly string NewUsername;

        public UserUpdateUsernameResponse(EGatewayErrorCode errorCode, bool isSuccess, string newUsername)
        {
            ErrorCode = errorCode;
            IsSuccess = isSuccess;
            NewUsername = newUsername;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(IsSuccess);
            writer.Write(NewUsername);
        }
    }
}