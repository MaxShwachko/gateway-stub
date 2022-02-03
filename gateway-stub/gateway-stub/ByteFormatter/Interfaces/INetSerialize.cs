namespace GatewayStub.ByteFormatter.Interfaces
{
	public interface INetSerialize
	{
		void NetSerialize(ByteWriter writer);
		void NetDeserialize(ByteReader reader);
	}
}