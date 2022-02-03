using System.Collections;

namespace GatewayStub.ByteFormatter.StateSerialize
{
	public interface IByteConvertable
	{
		IEnumerator ToByte(ByteWriter writer);

		void FromByte(ByteReader reader);
	}
}