using System.Collections;

namespace GatewayStub.ByteFormatter.Utils
{
	public static class EnumerateExtensions
	{
		public static void Enumerate(this IEnumerator enumerator)
		{
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current as IEnumerator;
				current?.Enumerate();
			}
		}
	}
}