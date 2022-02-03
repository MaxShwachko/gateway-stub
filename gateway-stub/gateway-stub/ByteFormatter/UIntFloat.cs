using System.Runtime.InteropServices;

namespace GatewayStub.ByteFormatter
{
	[StructLayout(LayoutKind.Explicit)]
	public struct UIntFloat
	{
		[FieldOffset(0)] public float floatValue;
		[FieldOffset(0)] public uint intValue;
		[FieldOffset(0)] public double doubleValue;
		[FieldOffset(0)] public ulong longValue;
	}
}