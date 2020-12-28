using System;
using System.Collections.Generic;
using System.Text;

namespace WaveEngine.Bindings.OpenXR
{
    /// <summary>
    /// A boolean value stored in a 4-byte unsigned integer.
    /// </summary>
    public struct XrBool32 : IEquatable<XrBool32>
    {
        /// <summary>
        /// Represents the boolean "true" value. Has a raw value of 1.
        /// </summary>
        public static readonly XrBool32 True = new XrBool32(1);

        /// <summary>
        /// Represents the boolean "true" value. Has a raw value of 0.
        /// </summary>
        public static readonly XrBool32 False = new XrBool32(0);

        /// <summary>
        /// The raw value of the <see cref="XrBool32"/>. A value of 0 represents "false", all other values represent "true".
        /// </summary>
        public uint Value;

        /// <summary>
        /// Constructs a new <see cref="XrBool32"/> with the given raw value. 
        /// </summary>
        /// <param name="value"></param>
        public XrBool32(uint value)
        {
            Value = value;
        }

        /// <summary>
        /// Returns whether another <see cref="XrBool32"/> value is considered equal to this one.
        /// Two <see cref="XrBool32"/>s are considered equal when their raw values are equal.
        /// </summary>
        /// <param name="other">The value to compare to.</param>
        /// <returns>True if the other value's underlying raw value is equal to this instance's. False otherwise.</returns>
        public bool Equals(XrBool32 other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            return obj is XrBool32 b && Equals(b);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return $"{(this ? "True" : "False")} ({Value})";
        }

        public static implicit operator bool(XrBool32 b) => b.Value != 0;
        public static implicit operator uint(XrBool32 b) => b.Value;
        public static implicit operator XrBool32(bool b) => b ? True : False;
        public static implicit operator XrBool32(uint value) => new XrBool32(value);

        public static bool operator ==(XrBool32 left, XrBool32 right) => left.Value == right.Value;
        public static bool operator !=(XrBool32 left, XrBool32 right) => left.Value != right.Value;
    }
}
