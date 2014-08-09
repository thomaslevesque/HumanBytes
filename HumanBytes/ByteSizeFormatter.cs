using System;
using System.Globalization;
using HumanBytes.Properties;

namespace HumanBytes
{
    /// <summary>
    /// A formatter that converts a byte size to a human readable string.
    /// </summary>
    public class ByteSizeFormatter
    {
        #region Prefixes and multiples definitions

        private static readonly long[] _decimalMultiples =
        {
            1L,
            1000L,
            1000000L,
            1000000000L,
            1000000000000L,
            1000000000000000L,
            1000000000000000000L
        };

        private static readonly long[] _binaryMultiples =
        {
            1L,
            1024L,
            1024L * 1024L,
            1024L * 1024L * 1024L,
            1024L * 1024L * 1024L * 1024L,
            1024L * 1024L * 1024L * 1024L * 1024L,
            1024L * 1024L * 1024L * 1024L * 1024L * 1024L,
        };

        private static readonly string[] _binaryPrefixes =
        {
            "",
            "Ki",
            "Mi",
            "Gi",
            "Ti",
            "Pi",
            "Ei",
        };

        private static readonly string[] _decimalPrefixes =
        {
            "",
            "K",
            "M",
            "G",
            "T",
            "P",
            "E",
        };

        #endregion

        #region Private data

        private int _decimalPlaces;
        private string _numberFormat;
        private ByteSizeUnit _minUnit;
        private ByteSizeUnit _maxUnit;
        private ByteSizeRounding _roundingRule;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of ByteSizeFormatter
        /// </summary>
        public ByteSizeFormatter()
        {
            DecimalPlaces = 0;
            NumberFormat = "#,##0.###";
            Convention = ByteSizeConvention.Customary;
            MinUnit = ByteSizeUnit.Byte;
            MaxUnit = ByteSizeUnit.Exabyte;
            RoundingRule = ByteSizeRounding.Closest;
            UseFullWordForBytes = true;
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets the unit naming convention for this formatter.
        /// </summary>
        /// <value>The unit naming convention for this formatter. The default value is ByteSizeConvention.Customary.</value>
        public ByteSizeConvention Convention { get; set; }

        /// <summary>
        /// Gets or sets the culture used to format the byte size.
        /// </summary>
        /// <value>The culture used to format the byte size, or null to use the current culture. The default value is null.</value>
        public CultureInfo Culture { get; set; }

        /// <summary>
        /// Gets or sets the number of decimal places in the formatted size.
        /// </summary>
        /// <value>The number of decimal places in the formatted size. The default value is 0.</value>
        public int DecimalPlaces
        {
            get { return _decimalPlaces; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value");
                _decimalPlaces = value;
            }
        }

        /// <summary>
        /// Gets or sets the number format used to format the size.
        /// </summary>
        /// <value>The number format used to format the size. The default value is "#,##0.###".</value>
        public string NumberFormat
        {
            get { return _numberFormat; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                _numberFormat = value;
            }
        }

        /// <summary>
        /// Gets or sets the smallest unit used by the formatter.
        /// </summary>
        /// <value>The smallest unit used by the formatter. The default value is ByteSizeUnit.Byte.</value>
        public ByteSizeUnit MinUnit
        {
            get { return _minUnit; }
            set
            {
                if (!Enum.IsDefined(typeof(ByteSizeUnit), value))
                    throw new ArgumentOutOfRangeException("value");
                _minUnit = value;
                if (_maxUnit < _minUnit)
                    _maxUnit = _minUnit;
            }
        }

        /// <summary>
        /// Gets or sets the largest unit used by the formatter.
        /// </summary>
        /// <value>The largest unit used by the formatter. The default value is ByteSizeUnit.ExaByte.</value>
        public ByteSizeUnit MaxUnit
        {
            get { return _maxUnit; }
            set
            {
                if (!Enum.IsDefined(typeof(ByteSizeUnit), value))
                    throw new ArgumentOutOfRangeException("value");
                _maxUnit = value;
                if (_minUnit > _maxUnit)
                    _minUnit = _maxUnit;
            }
        }

        /// <summary>
        /// Gets or sets the rounding rule used by the formatter.
        /// </summary>
        /// <value>The rounding rule used by the formatter. The default value is ByteSizeRounding.Closest.</value>
        public ByteSizeRounding RoundingRule
        {
            get { return _roundingRule; }
            set
            {
                if (!Enum.IsDefined(typeof(ByteSizeRounding), value))
                    throw new ArgumentOutOfRangeException("value");
                _roundingRule = value;
            }
        }

        ///<summary>
        /// Gets or sets a value indicating whether sizes under 1KB/1KiB are formatted using
        /// the full unabbreviated "byte" word.
        ///</summary>
        /// <value>true to use the unabbreviated word "byte" for sizes under 1KB/1KiB,
        /// false to use the abbreviation. The default value is true.</value>
        public bool UseFullWordForBytes { get; set; }

        #endregion

        /// <summary>
        /// Formats the specified size.
        /// </summary>
        /// <param name="size">The size to format.</param>
        /// <returns>The formatted size.</returns>
        public string Format(long size)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size");

            long[] multiples = _binaryMultiples;
            string[] prefixes = _decimalPrefixes;

            switch (Convention)
            {
                case ByteSizeConvention.Binary:
                    //case ByteSizeConvention.IEC:
                    multiples = _binaryMultiples;
                    prefixes = _binaryPrefixes;
                    break;
                case ByteSizeConvention.Decimal:
                    //case ByteSizeConvention.SI:
                    multiples = _decimalMultiples;
                    prefixes = _decimalPrefixes;
                    break;
                case ByteSizeConvention.Customary:
                    multiples = _binaryMultiples;
                    prefixes = _decimalPrefixes;
                    break;
            }

            int k = (int)MinUnit;
            for (int i = k; i <= (int)MaxUnit; i++)
            {
                if (size < multiples[i])
                    break;
                k = i;
            }

            string byteText = Resources.ResourceManager.GetString("ByteSymbol", Culture);
            if (UseFullWordForBytes && k == 0)
            {
                byteText = size > 1
                            ? Resources.ResourceManager.GetString("BytesWord", Culture)
                            : Resources.ResourceManager.GetString("ByteWord", Culture);
            }
            decimal valueToDisplay = Round((decimal)size / multiples[k]);

            return string.Format(
                            "{0} {1}{2}",
                            valueToDisplay.ToString(NumberFormat, Culture),
                            prefixes[k],
                            byteText);
        }

        private decimal Round(decimal value)
        {
            if (RoundingRule == ByteSizeRounding.Closest)
                return Math.Round(value, DecimalPlaces);
            decimal factor = (decimal)Math.Pow(10, DecimalPlaces);
            Func<decimal, decimal> roundFunc = decimal.Ceiling;
            if (RoundingRule == ByteSizeRounding.Down)
                roundFunc = decimal.Floor;

            return roundFunc(value * factor) / factor;
        }

        private static readonly ByteSizeFormatter _default = new ByteSizeFormatter();

        /// <summary>
        /// Returns a default instance of ByteSizeFormatter. This formatter will be used by the ByteSize.ToString() method.
        /// </summary>
        public static ByteSizeFormatter Default { get { return _default; } }
    }
}
