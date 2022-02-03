using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.GameBalancer
{
    public class GameBalancerGameStartedNotification : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.GameBalancer;
        public override byte MethodId => (byte) EMethodId.GameBalancerGameStartedNotification;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly bool RoomStarted;

        public GameBalancerGameStartedNotification(EGatewayErrorCode errorCode, bool roomStarted)
        {
            ErrorCode = errorCode;
            RoomStarted = roomStarted;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(RoomStarted);
        }
    }
}