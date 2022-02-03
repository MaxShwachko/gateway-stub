using System;

namespace GatewayStub.ByteFormatter.StateSerialize
{
	[AttributeUsage(AttributeTargets.Property)]
	public class ByteDataIndexAttribute : Attribute
	{
		public readonly int Index;

		public ByteDataIndexAttribute(int index)
		{
			Index = index;
		}
	}
}