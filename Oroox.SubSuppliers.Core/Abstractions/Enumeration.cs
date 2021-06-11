using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Oroox.SubSuppliers.Utilities.Abstractions
{
    /// <summary>
    /// Enumeration class. 
    /// Currently no use in this Project.
    /// /// </summary>
    public abstract class Enumeration : IComparable
    {
        private const string VALUE = "value";
        private readonly int _value;
        private readonly string _displayName;

        protected Enumeration() { }
        protected Enumeration(int value, string displayName)
        {
            _value = value;
            _displayName = displayName;
        }

        public int Value => _value;
        public string DisplayName => _displayName;

        public override string ToString() => DisplayName;

        public static IEnumerable<TEnumerationType> GetAll<TEnumerationType>() where TEnumerationType : Enumeration, new()
        {
            Type type = typeof(TEnumerationType);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            return from FieldInfo info in fields
                       let instance = new TEnumerationType()
                       let locatedValue = info.GetValue(instance) as TEnumerationType
                       where locatedValue != null
                   select locatedValue;
        }

        public override bool Equals(object obj)
        {
            Enumeration otherValue = obj as Enumeration;

            if (otherValue is null)
            {
                return false;
            }

            bool typeMatches = GetType().Equals(obj.GetType());
            bool valueMatches = _value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode() => _value.GetHashCode();

        public static int AbsoluteDifference(Enumeration firstValue, Enumeration secondValue)
        {
            int absoluteDifference = Math.Abs(firstValue.Value - secondValue.Value);
            return absoluteDifference;
        }

        public static TEnumeration FromValue<TEnumeration>(int value) where TEnumeration : Enumeration, new()
        {
            TEnumeration matchingItem = Parse<TEnumeration, int>(value, VALUE, item => item.Value == value);
            return matchingItem;
        }

        public static TEnumeration FromDisplayName<TEnumeration>(string displayName) where TEnumeration : Enumeration, new()
        {
            TEnumeration matchingItem = Parse<TEnumeration, string>(displayName, "display name", item => item.DisplayName == displayName);
            return matchingItem;
        }

        private static TEnumeration Parse<TEnumeration, TValue>(TValue value, string description, Func<TEnumeration, bool> predicate) where TEnumeration : Enumeration, new()
        {
            TEnumeration matchingItem = GetAll<TEnumeration>().FirstOrDefault(predicate);

            if (matchingItem == null)
            {
                string message = string.Format("'{0}' is not a valid {1} in {2}", value, description, typeof(TEnumeration));
                throw new ApplicationException(message);
            }

            return matchingItem;
        }

        public int CompareTo(object other)
        {
            return Value.CompareTo(((Enumeration)other).Value);
        }
    }
}
