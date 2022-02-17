using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class LootboxDto : INetSerialize
    {
        public int LootboxId;
        public int BindingUid;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(LootboxId);
            writer.Write(BindingUid);
        }

        public void NetDeserialize(ByteReader reader)
        {
            LootboxId = reader.ReadInt32();
            BindingUid = reader.ReadInt32();
        }
    }
}