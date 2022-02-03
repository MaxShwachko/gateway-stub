using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;

namespace GatewayStub.Api.Models.Dto
{
    public class EquipmentItemDto : INetSerialize
    {
        public int EquipmentItemId;
        public int BindingUid;
        public string BlockId;
        public string LinkToExplorer;
        public string TransactionHash;
        public NetList<EquipmentEffectDto> Effects;
        public bool IsPending;

        public void NetSerialize(ByteWriter writer)
        {
            writer.Write(EquipmentItemId);
            writer.Write(BindingUid);
            writer.Write(BlockId);
            writer.Write(LinkToExplorer);
            writer.Write(TransactionHash);
            Effects.NetSerialize(writer);
            writer.Write(IsPending);
        }

        public void NetDeserialize(ByteReader reader)
        {
            EquipmentItemId = reader.ReadInt32();
            BindingUid = reader.ReadInt32();
            BlockId = reader.ReadString();
            LinkToExplorer = reader.ReadString();
            TransactionHash = reader.ReadString();
            Effects = DTOSerializer.NetDeserialize<NetList<EquipmentEffectDto>>(reader);
            IsPending = reader.ReadBoolean();
        }
    }
}