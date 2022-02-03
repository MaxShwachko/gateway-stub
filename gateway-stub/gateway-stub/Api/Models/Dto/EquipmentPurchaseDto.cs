using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class EquipmentPurchaseDto : INetSerialize
    {
        public int EquipmentItemId;
        public string ProductType;
        public string CurrencyType;
        public string Price;
        public NetList<EquipmentEffectDto> Effects;
        public bool IsSold;
        
        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(EquipmentItemId);
            writer.Write(ProductType);
            writer.Write(CurrencyType);
            writer.Write(Price);
            Effects.NetSerialize(writer);
            writer.Write(IsSold);
        }

        public void NetDeserialize(ByteReader reader)
        {
            EquipmentItemId = reader.ReadInt32();
            ProductType = reader.ReadString();
            CurrencyType = reader.ReadString();
            Price = reader.ReadString();
            Effects = DTOSerializer.NetDeserialize<NetList<EquipmentEffectDto>>(reader);
            IsSold = reader.ReadBoolean();
        }
    }
}