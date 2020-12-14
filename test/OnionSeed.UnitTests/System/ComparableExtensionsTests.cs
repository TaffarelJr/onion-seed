using FluentAssertions;
using Xunit;

namespace System
{
    public class ComparableExtensionsTests
    {
        [Fact]
        public void IsEqualTo_ShouldThrowException_WhenOtherIsWrongType()
        {
            // Arrange
            IComparable subject = 1;

            // Act
            Action action = () => subject.IsEqualTo("wrong type");

            // Assert
            action.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(null, null, true)]
        [InlineData(null, 0, false)]
        [InlineData(0, null, false)]
        [InlineData(2, 1, false)]
        [InlineData(2, 2, true)]
        [InlineData(2, 3, false)]
        public void IsEqualTo_ShouldReturnCorrectValues(int? s, int? o, bool expected)
        {
            // Arrange
            IComparable subject = s;

            // Act
            var result = subject.IsEqualTo(o);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void IsNotEqualTo_ShouldThrowException_WhenOtherIsWrongType()
        {
            // Arrange
            IComparable subject = 1;

            // Act
            Action action = () => subject.IsNotEqualTo("wrong type");

            // Assert
            action.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(null, null, false)]
        [InlineData(null, 0, true)]
        [InlineData(0, null, true)]
        [InlineData(2, 1, true)]
        [InlineData(2, 2, false)]
        [InlineData(2, 3, true)]
        public void IsNotEqualTo_ShouldReturnCorrectValues(int? s, int? o, bool expected)
        {
            // Arrange
            IComparable subject = s;

            // Act
            var result = subject.IsNotEqualTo(o);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void IsLessThan_ShouldThrowException_WhenOtherIsWrongType()
        {
            // Arrange
            IComparable subject = 1;

            // Act
            Action action = () => subject.IsLessThan("wrong type");

            // Assert
            action.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(null, null, false)]
        [InlineData(null, 0, true)]
        [InlineData(0, null, false)]
        [InlineData(2, 1, false)]
        [InlineData(2, 2, false)]
        [InlineData(2, 3, true)]
        public void IsLessThan_ShouldReturnCorrectValues(int? s, int? o, bool expected)
        {
            // Arrange
            IComparable subject = s;

            // Act
            var result = subject.IsLessThan(o);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void IsLessThanOrEqualTo_ShouldThrowException_WhenOtherIsWrongType()
        {
            // Arrange
            IComparable subject = 1;

            // Act
            Action action = () => subject.IsLessThanOrEqualTo("wrong type");

            // Assert
            action.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(null, null, true)]
        [InlineData(null, 0, true)]
        [InlineData(0, null, false)]
        [InlineData(2, 1, false)]
        [InlineData(2, 2, true)]
        [InlineData(2, 3, true)]
        public void IsLessThanOrEqualTo_ShouldReturnCorrectValues(int? s, int? o, bool expected)
        {
            // Arrange
            IComparable subject = s;

            // Act
            var result = subject.IsLessThanOrEqualTo(o);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void IsGreaterThan_ShouldThrowException_WhenOtherIsWrongType()
        {
            // Arrange
            IComparable subject = 1;

            // Act
            Action action = () => subject.IsGreaterThan("wrong type");

            // Assert
            action.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(null, null, false)]
        [InlineData(null, 0, false)]
        [InlineData(0, null, true)]
        [InlineData(2, 1, true)]
        [InlineData(2, 2, false)]
        [InlineData(2, 3, false)]
        public void IsGreaterThan_ShouldReturnCorrectValues(int? s, int? o, bool expected)
        {
            // Arrange
            IComparable subject = s;

            // Act
            var result = subject.IsGreaterThan(o);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void IsGreaterThanOrEqualTo_ShouldThrowException_WhenOtherIsWrongType()
        {
            // Arrange
            IComparable subject = 1;

            // Act
            Action action = () => subject.IsGreaterThanOrEqualTo("wrong type");

            // Assert
            action.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(null, null, true)]
        [InlineData(null, 0, false)]
        [InlineData(0, null, true)]
        [InlineData(2, 1, true)]
        [InlineData(2, 2, true)]
        [InlineData(2, 3, false)]
        public void IsGreaterThanOrEqualTo_ShouldReturnCorrectValues(int? s, int? o, bool expected)
        {
            // Arrange
            IComparable subject = s;

            // Act
            var result = subject.IsGreaterThanOrEqualTo(o);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void IsBetween_ShouldThrowException_WhenMinIsObject_AndRangeContainsWrongType(bool wrongMin, bool wrongMax)
        {
            // Arrange
            var min = wrongMin ? (object)"wrong type" : 4;
            var max = wrongMax ? (object)"wrong type" : 8;

            IComparable subject = 1;

            // Act
            Action action = () => subject.IsBetween(min, max);

            // Assert
            action.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(0, null)]
        [InlineData(2, 1)]
        public void IsBetween_ShouldThrowException_WhenMinIsObject_AndMinIsGreaterThanMax(int? min, int? max)
        {
            // Arrange
            IComparable subject = 1;

            // Act
            Action action = () => subject.IsBetween((object)min, max);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(null, null, null, true)]
        [InlineData(null, null, 0, true)]
        [InlineData(null, 0, 0, false)]
        [InlineData(0, null, null, false)]
        [InlineData(0, null, 0, true)]
        [InlineData(2, 1, 1, false)]
        [InlineData(2, 1, 2, true)]
        [InlineData(2, 1, 3, true)]
        [InlineData(2, 2, 2, true)]
        [InlineData(2, 2, 3, true)]
        [InlineData(2, 3, 3, false)]
        public void IsBetween_ShouldReturnCorrectValues_WhenMinIsObject(int? s, int? min, int? max, bool expected)
        {
            // Arrange
            IComparable subject = s;

            // Act
            var result = subject.IsBetween((object)min, max);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void IsBetween_ShouldThrowException_WhenMinIsComparable_AndRangeContainsWrongType(bool wrongMin, bool wrongMax)
        {
            // Arrange
            var min = wrongMin ? (IComparable)"wrong type" : 4;
            var max = wrongMax ? (object)"wrong type" : 8;

            IComparable subject = 1;

            // Act
            Action action = () => subject.IsBetween(min, max);

            // Assert
            action.Should().Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(0, null)]
        [InlineData(2, 1)]
        public void IsBetween_ShouldThrowException_WhenMinIsComparable_AndMinIsGreaterThanMax(int? min, int? max)
        {
            // Arrange
            IComparable subject = 1;

            // Act
            Action action = () => subject.IsBetween(min, max);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(null, null, null, true)]
        [InlineData(null, null, 0, true)]
        [InlineData(null, 0, 0, false)]
        [InlineData(0, null, null, false)]
        [InlineData(0, null, 0, true)]
        [InlineData(2, 1, 1, false)]
        [InlineData(2, 1, 2, true)]
        [InlineData(2, 1, 3, true)]
        [InlineData(2, 2, 2, true)]
        [InlineData(2, 2, 3, true)]
        [InlineData(2, 3, 3, false)]
        public void IsBetween_ShouldReturnCorrectValues_WhenMinIsComparable(int? s, int? min, int? max, bool expected)
        {
            // Arrange
            IComparable subject = s;

            // Act
            var result = subject.IsBetween(min, max);

            // Assert
            result.Should().Be(expected);
        }
    }
}
