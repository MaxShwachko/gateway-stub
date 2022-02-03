using System;

namespace GatewayStub.ByteFormatter.StateSerialize
{
	[AttributeUsage(AttributeTargets.Class)]
	public class ByteDataContextAttribute : Attribute
	{
		public readonly string Name;

		public ByteDataContextAttribute(string name)
		{
			Name = name;
		}
	}
}