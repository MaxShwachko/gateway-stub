using GatewayStub.ByteFormatter;
using GatewayStub.ByteFormatter.Interfaces;
using GatewayStub.Domain.Enums;

namespace GatewayStub.Api.Models.Dto
{
	public class LootboxDto : INetSerialize
	{
		public int LootboxId;
		public int BindingUid;
		public EProductState State;

		public void NetSerialize(ByteWriter writer)
		{
			writer.Write(LootboxId);
			writer.Write(BindingUid);
			writer.Write((int) State);
		}

		public void NetDeserialize(ByteReader reader)
		{
			LootboxId = reader.ReadInt32();
			BindingUid = reader.ReadInt32();
			State = (EProductState) reader.ReadInt32();
		}
	}
}