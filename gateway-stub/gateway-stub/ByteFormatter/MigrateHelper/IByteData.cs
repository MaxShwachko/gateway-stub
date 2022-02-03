namespace GatewayStub.ByteFormatter.MigrateHelper
{
	public interface IByteData
	{
		void Transfer(ByteReader reader, ByteWriter writer);

		void Skip(ByteReader reader);
	}
}