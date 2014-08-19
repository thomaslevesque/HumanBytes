using System;

namespace HumanBytes
{
    /// <summary>
    /// Represents a size in bytes.
    /// </summary>
    public struct ByteSize
    {
        private readonly long _value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ByteSize"/> struct.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        public ByteSize(long value)
        {
            _value = value;
        }

        /// <summary>
        /// Gets the size in bytes.
        /// </summary>
        /// <value>
        /// The size in bytes.
        /// </value>
        public long Value
        {
            get { return _value; }
        }

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
            return ByteSizeFormatter.Default.Format(_value);
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
            if (formatter == null) throw new ArgumentNullException("formatter");
            return formatter.Format(_value);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Int64"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(long value)
        {
            return new ByteSize(value);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.UInt64"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(ulong value)
        {
            return new ByteSize(checked((long)value));
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Int32"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(int value)
        {
            return new ByteSize(value);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.UInt32"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(uint value)
        {
            return new ByteSize(value);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Int16"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(short value)
        {
            return new ByteSize(value);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.UInt16"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(ushort value)
        {
            return new ByteSize(value);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Byte"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(byte value)
        {
            return new ByteSize(value);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.SByte"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(sbyte value)
        {
            return new ByteSize(value);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Double"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(double value)
        {
            return new ByteSize(checked((long) value));
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Single"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(float value)
        {
            return new ByteSize(checked((long) value));
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Decimal"/> to <see cref="ByteSize"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator ByteSize(decimal value)
        {
            return new ByteSize(checked((long) value));
        }
    }
}
