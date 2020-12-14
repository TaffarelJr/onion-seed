using FluentAssertions;
using Xunit;

namespace System
{
    public class ComparableTExtensionsTests
    {
        [Theory]
        [InlineData(2, 1, false)]
        [InlineData(2, 2, true)]
        [InlineData(2, 3, false)]
        public void IsEqualTo_ShouldReturnCorrectValues_WhenTypeIsStruct(int s, int o, bool expected)
        {
            // Arrange
            IComparable<int> subject = s;

            // Act
            var result = subject.IsEqualTo(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null, true)]
        [InlineData(null, "", false)]
        [InlineData("", null, false)]
        [InlineData("b", "a", false)]
        [InlineData("b", "b", true)]
        [InlineData("b", "c", false)]
        public void IsEqualTo_ShouldReturnCorrectValues_WhenTypeIsClass(string s, string o, bool expected)
        {
            // Arrange
            IComparable<string> subject = s;

            // Act
            var result = subject.IsEqualTo(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 1, true)]
        [InlineData(2, 2, false)]
        [InlineData(2, 3, true)]
        public void IsNotEqualTo_ShouldReturnCorrectValues_WhenTypeIsStruct(int s, int o, bool expected)
        {
            // Arrange
            IComparable<int> subject = s;

            // Act
            var result = subject.IsNotEqualTo(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null, false)]
        [InlineData(null, "", true)]
        [InlineData("", null, true)]
        [InlineData("b", "a", true)]
        [InlineData("b", "b", false)]
        [InlineData("b", "c", true)]
        public void IsNotEqualTo_ShouldReturnCorrectValues_WhenTypeIsClass(string s, string o, bool expected)
        {
            // Arrange
            IComparable<string> subject = s;

            // Act
            var result = subject.IsNotEqualTo(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 1, false)]
        [InlineData(2, 2, false)]
        [InlineData(2, 3, true)]
        public void IsLessThan_ShouldReturnCorrectValues_WhenTypeIsStruct(int s, int o, bool expected)
        {
            // Arrange
            IComparable<int> subject = s;

            // Act
            var result = subject.IsLessThan(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null, false)]
        [InlineData(null, "", true)]
        [InlineData("", null, false)]
        [InlineData("b", "a", false)]
        [InlineData("b", "b", false)]
        [InlineData("b", "c", true)]
        public void IsLessThan_ShouldReturnCorrectValues_WhenTypeIsClass(string s, string o, bool expected)
        {
            // Arrange
            IComparable<string> subject = s;

            // Act
            var result = subject.IsLessThan(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 1, false)]
        [InlineData(2, 2, true)]
        [InlineData(2, 3, true)]
        public void IsLessThanOrEqualTo_ShouldReturnCorrectValues_WhenTypeIsStruct(int s, int o, bool expected)
        {
            // Arrange
            IComparable<int> subject = s;

            // Act
            var result = subject.IsLessThanOrEqualTo(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null, true)]
        [InlineData(null, "", true)]
        [InlineData("", null, false)]
        [InlineData("b", "a", false)]
        [InlineData("b", "b", true)]
        [InlineData("b", "c", true)]
        public void IsLessThanOrEqualTo_ShouldReturnCorrectValues_WhenTypeIsClass(string s, string o, bool expected)
        {
            // Arrange
            IComparable<string> subject = s;

            // Act
            var result = subject.IsLessThanOrEqualTo(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 1, true)]
        [InlineData(2, 2, false)]
        [InlineData(2, 3, false)]
        public void IsGreaterThan_ShouldReturnCorrectValues_WhenTypeIsStruct(int s, int o, bool expected)
        {
            // Arrange
            IComparable<int> subject = s;

            // Act
            var result = subject.IsGreaterThan(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null, false)]
        [InlineData(null, "", false)]
        [InlineData("", null, true)]
        [InlineData("b", "a", true)]
        [InlineData("b", "b", false)]
        [InlineData("b", "c", false)]
        public void IsGreaterThan_ShouldReturnCorrectValues_WhenTypeIsClass(string s, string o, bool expected)
        {
            // Arrange
            IComparable<string> subject = s;

            // Act
            var result = subject.IsGreaterThan(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 1, true)]
        [InlineData(2, 2, true)]
        [InlineData(2, 3, false)]
        public void IsGreaterThanOrEqualTo_ShouldReturnCorrectValues_WhenTypeIsStruct(int s, int o, bool expected)
        {
            // Arrange
            IComparable<int> subject = s;

            // Act
            var result = subject.IsGreaterThanOrEqualTo(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null, true)]
        [InlineData(null, "", false)]
        [InlineData("", null, true)]
        [InlineData("b", "a", true)]
        [InlineData("b", "b", true)]
        [InlineData("b", "c", false)]
        public void IsGreaterThanOrEqualTo_ShouldReturnCorrectValues_WhenTypeIsClass(string s, string o, bool expected)
        {
            // Arrange
            IComparable<string> subject = s;

            // Act
            var result = subject.IsGreaterThanOrEqualTo(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 1)]
        public void IsBetween_ShouldThrowException_WhenTypeIsStruct_AndMinIsGreaterThanMax(int min, int max)
        {
            // Arrange
            IComparable<int> subject = 1;

            // Act
            Action action = () => subject.IsBetween(min, max);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(2, 1, 1, false)]
        [InlineData(2, 1, 2, true)]
        [InlineData(2, 1, 3, true)]
        [InlineData(2, 2, 2, true)]
        [InlineData(2, 2, 3, true)]
        [InlineData(2, 3, 3, false)]
        public void IsBetween_ShouldReturnCorrectValues_WhenypeIsStruct(int s, int min, int max, bool expected)
        {
            // Arrange
            IComparable<int> subject = s;

            // Act
            var result = subject.IsBetween(min, max);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("", null)]
        [InlineData("b", "a")]
        public void IsBetween_ShouldThrowException_WhenTypeIsClass_AndMinIsGreaterThanMax(string min, string max)
        {
            // Arrange
            IComparable<string> subject = string.Empty;

            // Act
            Action action = () => subject.IsBetween(min, max);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(null, null, null, true)]
        [InlineData(null, null, "", true)]
        [InlineData(null, "", "", false)]
        [InlineData("", null, null, false)]
        [InlineData("", null, "", true)]
        [InlineData("b", "a", "a", false)]
        [InlineData("b", "a", "b", true)]
        [InlineData("b", "a", "c", true)]
        [InlineData("b", "b", "b", true)]
        [InlineData("b", "b", "c", true)]
        [InlineData("b", "c", "c", false)]
        public void IsBetween_ShouldReturnCorrectValues_WhenypeIsClass(string s, string min, string max, bool expected)
        {
            // Arrange
            IComparable<string> subject = s;

            // Act
            var result = subject.IsBetween(min, max);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(2, 2, 2)]
        [InlineData(2, 3, 3)]
        public void ConstrainToMin_ShouldReturnCorrectValues_WhenTypeIsStruct(int subject, int min, int expected)
        {
            // Act
            var result = subject.ConstrainToMin(min);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null, null)]
        [InlineData(null, "", "")]
        [InlineData("", null, "")]
        [InlineData("b", "a", "b")]
        [InlineData("b", "b", "b")]
        [InlineData("b", "c", "c")]
        public void ConstrainToMin_ShouldReturnCorrectValues_WhenTypeIsClass(string subject, string min, string expected)
        {
            // Act
            var result = subject.ConstrainToMin(min);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(2, 2, 2)]
        [InlineData(2, 3, 2)]
        public void ConstrainToMax_ShouldReturnCorrectValues_WhenTypeIsStruct(int subject, int max, int expected)
        {
            // Act
            var result = subject.ConstrainToMax(max);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(null, null, null)]
        [InlineData(null, "", null)]
        [InlineData("", null, null)]
        [InlineData("b", "a", "a")]
        [InlineData("b", "b", "b")]
        [InlineData("b", "c", "b")]
        public void ConstrainToMax_ShouldReturnCorrectValues_WhenTypeIsClass(string subject, string max, string expected)
        {
            // Act
            var result = subject.ConstrainToMax(max);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 1)]
        public void ConstrainTo_ShouldThrowException_WhenTypeIsStruct_AndMinIsGreaterThanMax(int min, int max)
        {
            // Arrange
            var subject = 1;

            // Act
            Action action = () => subject.ConstrainTo(min, max);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(2, 1, 1, 1)]
        [InlineData(2, 1, 2, 2)]
        [InlineData(2, 1, 3, 2)]
        [InlineData(2, 2, 2, 2)]
        [InlineData(2, 2, 3, 2)]
        [InlineData(2, 3, 3, 3)]
        public void ConstrainTo_ShouldReturnCorrectValues_WhenypeIsStruct(int subject, int min, int max, int expected)
        {
            // Act
            var result = subject.ConstrainTo(min, max);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("", null)]
        [InlineData("b", "a")]
        public void ConstrainTo_ShouldThrowException_WhenTypeIsClass_AndMinIsGreaterThanMax(string min, string max)
        {
            // Arrange
            var subject = string.Empty;

            // Act
            Action action = () => subject.ConstrainTo(min, max);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(null, null, null, null)]
        [InlineData(null, null, "", null)]
        [InlineData(null, "", "", "")]
        [InlineData("", null, null, null)]
        [InlineData("", null, "", "")]
        [InlineData("b", "a", "a", "a")]
        [InlineData("b", "a", "b", "b")]
        [InlineData("b", "a", "c", "b")]
        [InlineData("b", "b", "b", "b")]
        [InlineData("b", "b", "c", "b")]
        [InlineData("b", "c", "c", "c")]
        public void ConstrainTo_ShouldReturnCorrectValues_WhenypeIsClass(string subject, string min, string max, string expected)
        {
            // Act
            var result = subject.ConstrainTo(min, max);

            // Assert
            result.Should().Be(expected);
        }
    }
}
