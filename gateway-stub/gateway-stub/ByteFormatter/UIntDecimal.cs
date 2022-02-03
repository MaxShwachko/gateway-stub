using System.Runtime.InteropServices;

namespace GatewayStub.ByteFormatter
{
	[StructLayout(LayoutKind.Explicit)]
	public struct UIntDecimal
	{
		[FieldOffset(0)] public ulong longValue1;
		[FieldOffset(8)] public ulong longValue2;
		[FieldOffset(0)] public decimal decimalValue;
	}
}