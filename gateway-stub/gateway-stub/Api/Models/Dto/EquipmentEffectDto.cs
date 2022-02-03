using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Models.Dto
{
    public class EquipmentEffectDto : INetSerialize
    {
        public EHeroStatType StatToEffect;
        public string Power;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write((byte) StatToEffect);
            writer.Write(Power);
        }

        public void NetDeserialize(ByteReader reader)
        {
            StatToEffect = (EHeroStatType) reader.ReadByte();
            Power = reader.ReadString();
        }
    }
}