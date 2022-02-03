using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class LobbyStartGameResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.LobbyStartGame;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly bool IsSuccess;

        public LobbyStartGameResponse(EGatewayErrorCode errorCode, bool isSuccess)
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