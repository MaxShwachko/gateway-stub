using System;

namespace GatewayStub.ByteFormatter.MigrateHelper
{
	[AttributeUsage(AttributeTargets.Class)]
	public class DataVersionAttribute : Attribute
	{
		public string TypeName { get; }
		public string Version { get; }

		public DataVersionAttribute(string typeName, string version)
		{
			Version = version;
			TypeName = typeName;
		}

		protected bool Equals(DataVersionAttribute other) => TypeName == other.TypeName && Version == other.Version;

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((DataVersionAttribute) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hashCode = base.GetHashCode();
				hashCode = (hashCode * 397) ^ (TypeName != null ? TypeName.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Version != null ? Version.GetHashCode() : 0);
				return hashCode;
			}
		}
	}
}