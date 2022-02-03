namespace GatewayStub.ByteFormatter.MigrateHelper.Impls
{
	public abstract class AByteData<T> : IByteData
		where T : class, IByteData, new()
	{
		public static readonly T Instance = new T();

		public abstract void Transfer(ByteReader reader, ByteWriter writer);

		public abstract void Skip(ByteReader reader);
	}
}