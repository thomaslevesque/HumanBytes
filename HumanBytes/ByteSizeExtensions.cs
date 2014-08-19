namespace HumanBytes
{
    /// <summary>
    /// Provide extension methods to convert numeric values to instances of <see cref="ByteSize"/>.
    /// </summary>
    public static class ByteSizeExtensions
    {
        /// <summary>
        /// Returns an instance of <see cref="ByteSize"/> that represents the specified size.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        /// <returns>An instance of <see cref="ByteSize"/> that represents the specified size.</returns>
        public static ByteSize Bytes(this long value)
        {
            return value;
        }

        /// <summary>
        /// Returns an instance of <see cref="ByteSize"/> that represents the specified size.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        /// <returns>An instance of <see cref="ByteSize"/> that represents the specified size.</returns>
        public static ByteSize Bytes(this ulong value)
        {
            return value;
        }

        /// <summary>
        /// Returns an instance of <see cref="ByteSize"/> that represents the specified size.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        /// <returns>An instance of <see cref="ByteSize"/> that represents the specified size.</returns>
        public static ByteSize Bytes(this int value)
        {
            return value;
        }

        /// <summary>
        /// Returns an instance of <see cref="ByteSize"/> that represents the specified size.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        /// <returns>An instance of <see cref="ByteSize"/> that represents the specified size.</returns>
        public static ByteSize Bytes(this uint value)
        {
            return value;
        }

        /// <summary>
        /// Returns an instance of <see cref="ByteSize"/> that represents the specified size.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        /// <returns>An instance of <see cref="ByteSize"/> that represents the specified size.</returns>
        public static ByteSize Bytes(this short value)
        {
            return value;
        }

        /// <summary>
        /// Returns an instance of <see cref="ByteSize"/> that represents the specified size.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        /// <returns>An instance of <see cref="ByteSize"/> that represents the specified size.</returns>
        public static ByteSize Bytes(this ushort value)
        {
            return value;
        }

        /// <summary>
        /// Returns an instance of <see cref="ByteSize"/> that represents the specified size.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        /// <returns>An instance of <see cref="ByteSize"/> that represents the specified size.</returns>
        public static ByteSize Bytes(this byte value)
        {
            return value;
        }

        /// <summary>
        /// Returns an instance of <see cref="ByteSize"/> that represents the specified size.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        /// <returns>An instance of <see cref="ByteSize"/> that represents the specified size.</returns>
        public static ByteSize Bytes(this sbyte value)
        {
            return value;
        }

        /// <summary>
        /// Returns an instance of <see cref="ByteSize"/> that represents the specified size.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        /// <returns>An instance of <see cref="ByteSize"/> that represents the specified size.</returns>
        public static ByteSize Bytes(this double value)
        {
            return value;
        }

        /// <summary>
        /// Returns an instance of <see cref="ByteSize"/> that represents the specified size.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        /// <returns>An instance of <see cref="ByteSize"/> that represents the specified size.</returns>
        public static ByteSize Bytes(this float value)
        {
            return value;
        }

        /// <summary>
        /// Returns an instance of <see cref="ByteSize"/> that represents the specified size.
        /// </summary>
        /// <param name="value">The size in bytes.</param>
        /// <returns>An instance of <see cref="ByteSize"/> that represents the specified size.</returns>
        public static ByteSize Bytes(this decimal value)
        {
            return value;
        }
    }
}
