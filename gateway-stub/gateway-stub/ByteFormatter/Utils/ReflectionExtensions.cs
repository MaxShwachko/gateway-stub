using System;
using System.Reflection;

namespace GatewayStub.ByteFormatter.Utils
{
    public static class ReflectionExtensions
    {
        public static bool ImplementsInterface<T>(this Type type)
            => !type.IsInterface && type.GetInterface(typeof(T).FullName) != null;

        public static bool HasAttribute<T>(this MemberInfo type)
            where T : Attribute
            => type.GetCustomAttribute<T>() != null;
    }
}