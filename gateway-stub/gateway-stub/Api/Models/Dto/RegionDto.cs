using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class RegionDto : INetSerialize
    {
        public string Name;
        public string Host;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(Name);
            writer.Write(Host);
        }

        public void NetDeserialize(ByteReader reader)
        {
            Name = reader.ReadString();
            Host = reader.ReadString();
        }
    }
}