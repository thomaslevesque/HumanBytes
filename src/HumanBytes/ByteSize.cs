using System;

namespace HumanBytes
{
    /// <summary>
    /// Represents a size in bytes.
    /// </summary>
    public readonly struct ByteSize : IEquatable<ByteSize>, IComparable<ByteSize>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ByteSize"/> struct.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        public ByteSize(long value) => Value = value;

        /// <summary>
        /// Gets the size in bytes.
        /// </summary>
        /// <value>
        /// The size in bytes.
        /// </value>
        public long Value { get; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        /// <remarks>
        /// The size is formatted to a human readable format using the default formatter (<see cref="ByteSizeFormatter.Default"/>).
        /// </remarks>
        public override string ToString()
        {
            return ByteSizeFormatter.Default.Format(Value);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance, using the specified formatter.
        /// </summary>
        /// <param name="formatter">The formatter to use.</param>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        /// <exception cref="System.ArgumentNullException"><c>formatter</c> is null.</exception>
        public string ToString(ByteSizeFormatter formatter)
        {
            if (formatter == null) throw new ArgumentNullException(nameof(formatter));
            return formatter.Format(Value);
        }

        /// <inheritdoc />
        public bool Equals(ByteSize other) => Value == other.Value;

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is ByteSize other && Equals(other);

        /// <inheritdoc />
        public override int GetHashCode() => Value.GetHashCode();

        /// <summary>
        /// Determines whether two specified instances of <see cref="ByteSize"/> are equal.
        /// </summary>
        /// <param name="left">The first <see cref="ByteSize"/> instance to compare.</param>
        /// <param name="right">The second <see cref="ByteSize"/> instance to compare.</param>
        /// <returns></returns>
        public static bool operator ==(ByteSize left, ByteSize right) => left.Equals(right);

        /// <summary>
        /// Determines whether two specified instances of <see cref="ByteSize"/> are not equal.
        /// </summary>
        /// <param name="left">The first <see cref="ByteSize"/> instance to compare.</param>
        /// <param name="right">The second <see cref="ByteSize"/> instance to compare.</param>
        /// <returns></returns>
        public static bool operator !=(ByteSize left, ByteSize right) => !left.Equals(right);

        /// <inheritdoc />
        public int CompareTo(ByteSize other) => Value.CompareTo(other.Value);

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Int64"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(long value) => new ByteSize(value);

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.UInt64"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(ulong value) => new ByteSize(checked((long)value));

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Int32"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(int value) => new ByteSize(value);

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.UInt32"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(uint value) => new ByteSize(value);

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Int16"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(short value) => new ByteSize(value);

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.UInt16"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(ushort value) => new ByteSize(value);

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Byte"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(byte value) => new ByteSize(value);

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.SByte"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(sbyte value) => new ByteSize(value);

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Double"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(double value) => new ByteSize(checked((long) value));

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Single"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(float value) => new ByteSize(checked((long) value));

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Decimal"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(decimal value) => new ByteSize((long) value);
    }
}
