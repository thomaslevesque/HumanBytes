using Xunit;

namespace HumanBytes.Tests
{
    public class ByteSizeTests
    {
        #region Equals(object)

        [Fact]
        public void Equals_with_object_returns_true_if_parameter_is_ByteSize_with_same_value()
        {
            var left = new ByteSize(256);
            object right = new ByteSize(256);
            Assert.True(left.Equals(right));
        }

        [Fact]
        public void Equals_with_object_returns_false_if_parameter_is_ByteSize_with_different_value()
        {
            var left = new ByteSize(256);
            object right = new ByteSize(128);
            Assert.False(left.Equals(right));
        }

        [Fact]
        public void Equals_with_object_returns_false_if_parameter_is_not_ByteSize()
        {
            var left = new ByteSize(256);
            var right = "hello";
            Assert.False(left.Equals(right));
        }

        #endregion

        #region Equals(ByteSize)

        [Fact]
        public void Equals_with_ByteSize_returns_true_if_parameter_has_same_value()
        {
            var left = new ByteSize(256);
            var right = new ByteSize(256);
            Assert.True(left.Equals(right));
        }

        [Fact]
        public void Equals_with_ByteSize_returns_false_if_parameter_has_different_value()
        {
            var left = new ByteSize(256);
            var right = new ByteSize(128);
            Assert.False(left.Equals(right));
        }

        #endregion

        #region Operator ==

        [Fact]
        public void Equality_operator_returns_true_if_parameter_has_same_value()
        {
            var left = new ByteSize(256);
            var right = new ByteSize(256);
            Assert.True(left == right);
        }

        [Fact]
        public void Equality_operator_returns_false_if_parameter_has_different_value()
        {
            var left = new ByteSize(256);
            var right = new ByteSize(128);
            Assert.False(left == right);
        }

        #endregion

        #region Operator !=

        [Fact]
        public void Inequality_operator_returns_false_if_parameter_has_same_value()
        {
            var left = new ByteSize(256);
            var right = new ByteSize(256);
            Assert.False(left != right);
        }

        [Fact]
        public void Inequality_operator_returns_true_if_parameter_has_different_value()
        {
            var left = new ByteSize(256);
            var right = new ByteSize(128);
            Assert.True(left != right);
        }

        #endregion

        #region CompareTo

        [Theory]
        [InlineData(128, 128, 0)]
        [InlineData(128, 256, -1)]
        [InlineData(256, 128, 1)]
        public void CompareTo_returns_value_indicating_which_is_greater(int left, int right, int expected)
        {
            Assert.Equal(expected, left.Bytes().CompareTo(right.Bytes()));
        }

        #endregion
    }
}