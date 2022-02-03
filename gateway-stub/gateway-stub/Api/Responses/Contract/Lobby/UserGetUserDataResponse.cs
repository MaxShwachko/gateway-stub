using GatewayStub.Api.Enums;
using GatewayStub.ByteFormatter;
using GatewayStub.Core.Exchange;

namespace GatewayStub.Api.Responses.Contract.Lobby
{
    public class UserGetUserDataResponse : AContractResponse
    {
        public override byte AgentId => (byte) EAgentId.Lobby;
        public override byte MethodId => (byte) EMethodId.UserGetUserData;
        
        public readonly EGatewayErrorCode ErrorCode;
        public readonly string Username;
        public readonly int Rating;
        public readonly byte IncreaseBy;
        public readonly byte DecreaseBy;
        public readonly byte Draw;
        public readonly int PlaceInLeaderBoard;
        public readonly byte Image;
        public readonly string Email;
        public readonly string TokensIncreaseBy;

        public UserGetUserDataResponse(EGatewayErrorCode errorCode, string username, int rating, byte increaseBy, byte decreaseBy, byte draw, int placeInLeaderBoard, byte image, string email, string tokensIncreaseBy)
        {
            ErrorCode = errorCode;
            Username = username;
            Rating = rating;
            IncreaseBy = increaseBy;
            DecreaseBy = decreaseBy;
            Draw = draw;
            PlaceInLeaderBoard = placeInLeaderBoard;
            Image = image;
            Email = email;
            TokensIncreaseBy = tokensIncreaseBy;
        }

        protected override void WriteBody(ByteWriter writer)
        {
            writer.Write((int) ErrorCode);
            writer.Write(Username);
            writer.Write(Rating);
            writer.Write(IncreaseBy);
            writer.Write(DecreaseBy);
            writer.Write(Draw);
            writer.Write(PlaceInLeaderBoard);
            writer.Write(Image);
            writer.Write(Email);
            writer.Write(TokensIncreaseBy);
        }
    }
}