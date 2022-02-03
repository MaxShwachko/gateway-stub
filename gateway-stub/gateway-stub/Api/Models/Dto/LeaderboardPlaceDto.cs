using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class LeaderboardPlaceDto : INetSerialize
    {
        public int Place;
        public string Username;
        public int Rating;
        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(Place);
            writer.Write(Username);
            writer.Write(Rating);
        }

        public void NetDeserialize(ByteReader reader)
        {
            Place = reader.ReadInt32();
            Username = reader.ReadString();
            Rating = reader.ReadInt32();
        }
    }
}