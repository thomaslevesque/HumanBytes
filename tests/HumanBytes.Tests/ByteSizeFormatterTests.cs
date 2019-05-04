using System.Globalization;
using Xunit;

namespace HumanBytes.Tests
{
    public class ByteSizeFormatterTests
    {
        [Theory]
        [InlineData(1L, "1 byte")]
        [InlineData(2L, "2 bytes")]
        [InlineData(123L, "123 bytes")]
        [InlineData(1024L, "1 KB")]
        [InlineData(2 * 1024L, "2 KB")]
        [InlineData(1024 * 1024L, "1 MB")]
        [InlineData(1024L * 1024L * 1024L, "1 GB")]
        [InlineData(1024L * 1024L * 1024L * 1024L, "1 TB")]
        [InlineData(1024L * 1024L * 1024L * 1024L * 1024L, "1 PB")]
        [InlineData(1024L * 1024L * 1024L * 1024L * 1024L * 1024L, "1 EB")]
        public void Format_correctly_formats_size_with_customary_convention(long size, string expected)
        {
            var formatter = new ByteSizeFormatter
            {
                Culture = CultureInfo.InvariantCulture,
                Convention = ByteSizeConvention.Customary
            };
            var actual = formatter.Format(size);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(1L, "1 byte")]
        [InlineData(2L, "2 bytes")]
        [InlineData(123L, "123 bytes")]
        [InlineData(1024L, "1 KiB")]
        [InlineData(2 * 1024L, "2 KiB")]
        [InlineData(1024 * 1024L, "1 MiB")]
        [InlineData(1024L * 1024L * 1024L, "1 GiB")]
        [InlineData(1024L * 1024L * 1024L * 1024L, "1 TiB")]
        [InlineData(1024L * 1024L * 1024L * 1024L * 1024L, "1 PiB")]
        [InlineData(1024L * 1024L * 1024L * 1024L * 1024L * 1024L, "1 EiB")]
        public void Format_correctly_formats_size_with_binary_convention(long size, string expected)
        {
            var formatter = new ByteSizeFormatter
            {
                Culture = CultureInfo.InvariantCulture,
                Convention = ByteSizeConvention.Binary
            };
            var actual = formatter.Format(size);
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(1L, "1 byte")]
        [InlineData(2L, "2 bytes")]
        [InlineData(123L, "123 bytes")]
        [InlineData(1000L, "1 KB")]
        [InlineData(2 * 1000L, "2 KB")]
        [InlineData(1000 * 1000L, "1 MB")]
        [InlineData(1000L * 1000L * 1000L, "1 GB")]
        [InlineData(1000L * 1000L * 1000L * 1000L, "1 TB")]
        [InlineData(1000L * 1000L * 1000L * 1000L * 1000L, "1 PB")]
        [InlineData(1000L * 1000L * 1000L * 1000L * 1000L * 1000L, "1 EB")]
        public void Format_correctly_formats_size_with_decimal_convention(long size, string expected)
        {
            var formatter = new ByteSizeFormatter
            {
                Culture = CultureInfo.InvariantCulture,
                Convention = ByteSizeConvention.Decimal
            };
            var actual = formatter.Format(size);
            Assert.Equal(expected, actual);
        }
    }
}
