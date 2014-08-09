namespace HumanBytes
{
    public struct ByteSize
    {
        private readonly long _value;

        public ByteSize(long value)
        {
            _value = value;
        }

        public long Value
        {
            get { return _value; }
        }

        public override string ToString()
        {
            return ByteSizeFormatter.Default.Format(_value);
        }

        public static implicit operator ByteSize(long value)
        {
            return new ByteSize(value);
        }

        public static implicit operator ByteSize(ulong value)
        {
            return new ByteSize(checked((long)value));
        }

        public static implicit operator ByteSize(int value)
        {
            return new ByteSize(value);
        }

        public static implicit operator ByteSize(uint value)
        {
            return new ByteSize(value);
        }

        public static implicit operator ByteSize(short value)
        {
            return new ByteSize(value);
        }

        public static implicit operator ByteSize(ushort value)
        {
            return new ByteSize(value);
        }

        public static implicit operator ByteSize(byte value)
        {
            return new ByteSize(value);
        }

        public static implicit operator ByteSize(sbyte value)
        {
            return new ByteSize(value);
        }

        public static implicit operator ByteSize(double value)
        {
            return new ByteSize(checked((long) value));
        }

        public static implicit operator ByteSize(float value)
        {
            return new ByteSize(checked((long) value));
        }

        public static implicit operator ByteSize(decimal value)
        {
            return new ByteSize(checked((long) value));
        }
    }
}
