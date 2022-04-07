using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

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
		public short Level;
		public short MaxLevel;
		public int LevelupScrollsCost;
		public EProductState State;

		public void NetSerialize(ByteWriter writer)
		{
			writer.Write(EquipmentItemId);
			writer.Write(BindingUid);
			writer.Write(BlockId);
			writer.Write(LinkToExplorer);
			writer.Write(TransactionHash);
			Effects.NetSerialize(writer);
			writer.Write(IsPending);
			writer.Write(Level);
			writer.Write(MaxLevel);
			writer.Write(LevelupScrollsCost);
			writer.Write((int) State);
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
			Level = reader.ReadInt16();
			MaxLevel = reader.ReadInt16();
			LevelupScrollsCost = reader.ReadInt32();
			State = (EProductState) reader.ReadInt32();
		}
	}
}