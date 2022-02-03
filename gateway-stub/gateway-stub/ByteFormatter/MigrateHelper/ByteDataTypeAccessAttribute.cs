using System;

namespace GatewayStub.ByteFormatter.MigrateHelper
{
	[AttributeUsage(AttributeTargets.Class)]
	public class ByteDataTypeAccessAttribute : Attribute
	{
		public readonly Type Type;

		public ByteDataTypeAccessAttribute(Type type)
		{
			Type = type;
		}
	}
}