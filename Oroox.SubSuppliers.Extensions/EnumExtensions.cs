using System;

namespace Oroox.SubSuppliers.Extensions
{
    public static class EnumExtensions  
    {
        public static string GetUniqueName(this Enum @enum, object value) 
            => Enum.GetName(@enum.GetType(), value) + value.ToString();
             
    }
}
