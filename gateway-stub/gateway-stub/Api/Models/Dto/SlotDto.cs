using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Models.Dto
{
    public class SlotDto : INetSerialize
    {
        public EEquipmentType Type;
        public int ItemUid;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write((byte) Type);
            writer.Write(ItemUid);
        }

        public void NetDeserialize(ByteReader reader)
        {
            Type = (EEquipmentType) reader.ReadByte();
            ItemUid = reader.ReadInt32();
        }
    }
}