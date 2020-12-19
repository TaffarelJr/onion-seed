using System;
using FluentAssertions;
using Xunit;

namespace OnionSeed.Utilities.FluentDate
{
    public class FluentTimeExtensionsTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(24)]
        public void At_ShouldValidateParameters_WhenHourIsSpecified(int hour)
        {
            // Arrange
            var subject = default(DateTime);

            // Act
            Action action = () => subject.At(hour);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(23)]
        public void At_ShouldReturnNewDateTime_WhenHourIsSpecified(int hour)
        {
            // Arrange
            var subject = default(DateTime);

            // Act
            var result = subject.At(hour);

            // Assert
            result.Year.Should().Be(1);
            result.Month.Should().Be(1);
            result.Day.Should().Be(1);
            result.Hour.Should().Be(hour);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(-1, -1)]
        [InlineData(-1, 0)]
        [InlineData(-1, 59)]
        [InlineData(-1, 60)]
        [InlineData(0, -1)]
        [InlineData(0, 60)]
        [InlineData(23, -1)]
        [InlineData(23, 60)]
        [InlineData(24, -1)]
        [InlineData(24, 0)]
        [InlineData(24, 59)]
        [InlineData(24, 60)]
        public void At_ShouldValidateParameters_WhenMinuteIsSpecified(int hour, int minute)
        {
            // Arrange
            var subject = default(DateTime);

            // Act
            Action action = () => subject.At(hour, minute);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 59)]
        [InlineData(23, 0)]
        [InlineData(23, 59)]
        public void At_ShouldReturnNewDateTime_WhenMinuteIsSpecified(int hour, int minute)
        {
            // Arrange
            var subject = default(DateTime);

            // Act
            var result = subject.At(hour, minute);

            // Assert
            result.Year.Should().Be(1);
            result.Month.Should().Be(1);
            result.Day.Should().Be(1);
            result.Hour.Should().Be(hour);
            result.Minute.Should().Be(minute);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(-1, -1, -1)]
        [InlineData(-1, -1, 0)]
        [InlineData(-1, -1, 59)]
        [InlineData(-1, -1, 60)]
        [InlineData(-1, 0, -1)]
        [InlineData(-1, 0, 0)]
        [InlineData(-1, 0, 59)]
        [InlineData(-1, 0, 60)]
        [InlineData(-1, 59, -1)]
        [InlineData(-1, 59, 0)]
        [InlineData(-1, 59, 59)]
        [InlineData(-1, 59, 60)]
        [InlineData(-1, 60, -1)]
        [InlineData(-1, 60, 0)]
        [InlineData(-1, 60, 59)]
        [InlineData(-1, 60, 60)]
        [InlineData(0, -1, -1)]
        [InlineData(0, -1, 0)]
        [InlineData(0, -1, 59)]
        [InlineData(0, -1, 60)]
        [InlineData(0, 0, -1)]
        [InlineData(0, 0, 60)]
        [InlineData(0, 59, -1)]
        [InlineData(0, 59, 60)]
        [InlineData(0, 60, -1)]
        [InlineData(0, 60, 0)]
        [InlineData(0, 60, 59)]
        [InlineData(0, 60, 60)]
        [InlineData(23, -1, -1)]
        [InlineData(23, -1, 0)]
        [InlineData(23, -1, 59)]
        [InlineData(23, -1, 60)]
        [InlineData(23, 0, -1)]
        [InlineData(23, 0, 60)]
        [InlineData(23, 59, -1)]
        [InlineData(23, 59, 60)]
        [InlineData(23, 60, -1)]
        [InlineData(23, 60, 0)]
        [InlineData(23, 60, 59)]
        [InlineData(23, 60, 60)]
        [InlineData(24, -1, -1)]
        [InlineData(24, -1, 0)]
        [InlineData(24, -1, 59)]
        [InlineData(24, -1, 60)]
        [InlineData(24, 0, -1)]
        [InlineData(24, 0, 0)]
        [InlineData(24, 0, 59)]
        [InlineData(24, 0, 60)]
        [InlineData(24, 59, -1)]
        [InlineData(24, 59, 0)]
        [InlineData(24, 59, 59)]
        [InlineData(24, 59, 60)]
        [InlineData(24, 60, -1)]
        [InlineData(24, 60, 0)]
        [InlineData(24, 60, 59)]
        [InlineData(24, 60, 60)]
        public void At_ShouldValidateParameters_WhenSecondIsSpecified(int hour, int minute, int second)
        {
            // Arrange
            var subject = default(DateTime);

            // Act
            Action action = () => subject.At(hour, minute, second);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 0, 59)]
        [InlineData(0, 59, 0)]
        [InlineData(0, 59, 59)]
        [InlineData(23, 0, 0)]
        [InlineData(23, 0, 59)]
        [InlineData(23, 59, 0)]
        [InlineData(23, 59, 59)]
        public void At_ShouldReturnNewDateTime_WhenSecondIsSpecified(int hour, int minute, int second)
        {
            // Arrange
            var subject = default(DateTime);

            // Act
            var result = subject.At(hour, minute, second);

            // Assert
            result.Year.Should().Be(1);
            result.Month.Should().Be(1);
            result.Day.Should().Be(1);
            result.Hour.Should().Be(hour);
            result.Minute.Should().Be(minute);
            result.Second.Should().Be(second);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(-1, -1, -1, -1)]
        [InlineData(-1, -1, -1, 0)]
        [InlineData(-1, -1, -1, 999)]
        [InlineData(-1, -1, -1, 1000)]
        [InlineData(-1, -1, 0, -1)]
        [InlineData(-1, -1, 0, 0)]
        [InlineData(-1, -1, 0, 999)]
        [InlineData(-1, -1, 0, 1000)]
        [InlineData(-1, -1, 59, -1)]
        [InlineData(-1, -1, 59, 0)]
        [InlineData(-1, -1, 59, 999)]
        [InlineData(-1, -1, 59, 1000)]
        [InlineData(-1, -1, 60, -1)]
        [InlineData(-1, -1, 60, 0)]
        [InlineData(-1, -1, 60, 999)]
        [InlineData(-1, -1, 60, 1000)]
        [InlineData(-1, 0, -1, -1)]
        [InlineData(-1, 0, -1, 0)]
        [InlineData(-1, 0, -1, 999)]
        [InlineData(-1, 0, -1, 1000)]
        [InlineData(-1, 0, 0, -1)]
        [InlineData(-1, 0, 0, 0)]
        [InlineData(-1, 0, 0, 999)]
        [InlineData(-1, 0, 0, 1000)]
        [InlineData(-1, 0, 59, -1)]
        [InlineData(-1, 0, 59, 0)]
        [InlineData(-1, 0, 59, 999)]
        [InlineData(-1, 0, 59, 1000)]
        [InlineData(-1, 0, 60, -1)]
        [InlineData(-1, 0, 60, 0)]
        [InlineData(-1, 0, 60, 999)]
        [InlineData(-1, 0, 60, 1000)]
        [InlineData(-1, 59, -1, -1)]
        [InlineData(-1, 59, -1, 0)]
        [InlineData(-1, 59, -1, 999)]
        [InlineData(-1, 59, -1, 1000)]
        [InlineData(-1, 59, 0, -1)]
        [InlineData(-1, 59, 0, 0)]
        [InlineData(-1, 59, 0, 999)]
        [InlineData(-1, 59, 0, 1000)]
        [InlineData(-1, 59, 59, -1)]
        [InlineData(-1, 59, 59, 0)]
        [InlineData(-1, 59, 59, 999)]
        [InlineData(-1, 59, 59, 1000)]
        [InlineData(-1, 59, 60, -1)]
        [InlineData(-1, 59, 60, 0)]
        [InlineData(-1, 59, 60, 999)]
        [InlineData(-1, 59, 60, 1000)]
        [InlineData(-1, 60, -1, -1)]
        [InlineData(-1, 60, -1, 0)]
        [InlineData(-1, 60, -1, 999)]
        [InlineData(-1, 60, -1, 1000)]
        [InlineData(-1, 60, 0, -1)]
        [InlineData(-1, 60, 0, 0)]
        [InlineData(-1, 60, 0, 999)]
        [InlineData(-1, 60, 0, 1000)]
        [InlineData(-1, 60, 59, -1)]
        [InlineData(-1, 60, 59, 0)]
        [InlineData(-1, 60, 59, 999)]
        [InlineData(-1, 60, 59, 1000)]
        [InlineData(-1, 60, 60, -1)]
        [InlineData(-1, 60, 60, 0)]
        [InlineData(-1, 60, 60, 999)]
        [InlineData(-1, 60, 60, 1000)]
        [InlineData(0, -1, -1, -1)]
        [InlineData(0, -1, -1, 0)]
        [InlineData(0, -1, -1, 999)]
        [InlineData(0, -1, -1, 1000)]
        [InlineData(0, -1, 0, -1)]
        [InlineData(0, -1, 0, 0)]
        [InlineData(0, -1, 0, 999)]
        [InlineData(0, -1, 0, 1000)]
        [InlineData(0, -1, 59, -1)]
        [InlineData(0, -1, 59, 0)]
        [InlineData(0, -1, 59, 999)]
        [InlineData(0, -1, 59, 1000)]
        [InlineData(0, -1, 60, -1)]
        [InlineData(0, -1, 60, 0)]
        [InlineData(0, -1, 60, 999)]
        [InlineData(0, -1, 60, 1000)]
        [InlineData(0, 0, -1, -1)]
        [InlineData(0, 0, -1, 0)]
        [InlineData(0, 0, -1, 999)]
        [InlineData(0, 0, -1, 1000)]
        [InlineData(0, 0, 0, -1)]
        [InlineData(0, 0, 0, 1000)]
        [InlineData(0, 0, 59, -1)]
        [InlineData(0, 0, 59, 1000)]
        [InlineData(0, 0, 60, -1)]
        [InlineData(0, 0, 60, 0)]
        [InlineData(0, 0, 60, 999)]
        [InlineData(0, 0, 60, 1000)]
        [InlineData(0, 59, -1, -1)]
        [InlineData(0, 59, -1, 0)]
        [InlineData(0, 59, -1, 999)]
        [InlineData(0, 59, -1, 1000)]
        [InlineData(0, 59, 0, -1)]
        [InlineData(0, 59, 0, 1000)]
        [InlineData(0, 59, 59, -1)]
        [InlineData(0, 59, 59, 1000)]
        [InlineData(0, 59, 60, -1)]
        [InlineData(0, 59, 60, 0)]
        [InlineData(0, 59, 60, 999)]
        [InlineData(0, 59, 60, 1000)]
        [InlineData(0, 60, -1, -1)]
        [InlineData(0, 60, -1, 0)]
        [InlineData(0, 60, -1, 999)]
        [InlineData(0, 60, -1, 1000)]
        [InlineData(0, 60, 0, -1)]
        [InlineData(0, 60, 0, 0)]
        [InlineData(0, 60, 0, 999)]
        [InlineData(0, 60, 0, 1000)]
        [InlineData(0, 60, 59, -1)]
        [InlineData(0, 60, 59, 0)]
        [InlineData(0, 60, 59, 999)]
        [InlineData(0, 60, 59, 1000)]
        [InlineData(0, 60, 60, -1)]
        [InlineData(0, 60, 60, 0)]
        [InlineData(0, 60, 60, 999)]
        [InlineData(0, 60, 60, 1000)]
        [InlineData(23, -1, -1, -1)]
        [InlineData(23, -1, -1, 0)]
        [InlineData(23, -1, -1, 999)]
        [InlineData(23, -1, -1, 1000)]
        [InlineData(23, -1, 0, -1)]
        [InlineData(23, -1, 0, 0)]
        [InlineData(23, -1, 0, 999)]
        [InlineData(23, -1, 0, 1000)]
        [InlineData(23, -1, 59, -1)]
        [InlineData(23, -1, 59, 0)]
        [InlineData(23, -1, 59, 999)]
        [InlineData(23, -1, 59, 1000)]
        [InlineData(23, -1, 60, -1)]
        [InlineData(23, -1, 60, 0)]
        [InlineData(23, -1, 60, 999)]
        [InlineData(23, -1, 60, 1000)]
        [InlineData(23, 0, -1, -1)]
        [InlineData(23, 0, -1, 0)]
        [InlineData(23, 0, -1, 999)]
        [InlineData(23, 0, -1, 1000)]
        [InlineData(23, 0, 0, -1)]
        [InlineData(23, 0, 0, 1000)]
        [InlineData(23, 0, 59, -1)]
        [InlineData(23, 0, 59, 1000)]
        [InlineData(23, 0, 60, -1)]
        [InlineData(23, 0, 60, 0)]
        [InlineData(23, 0, 60, 999)]
        [InlineData(23, 0, 60, 1000)]
        [InlineData(23, 59, -1, -1)]
        [InlineData(23, 59, -1, 0)]
        [InlineData(23, 59, -1, 999)]
        [InlineData(23, 59, -1, 1000)]
        [InlineData(23, 59, 0, -1)]
        [InlineData(23, 59, 0, 1000)]
        [InlineData(23, 59, 59, -1)]
        [InlineData(23, 59, 59, 1000)]
        [InlineData(23, 59, 60, -1)]
        [InlineData(23, 59, 60, 0)]
        [InlineData(23, 59, 60, 999)]
        [InlineData(23, 59, 60, 1000)]
        [InlineData(23, 60, -1, -1)]
        [InlineData(23, 60, -1, 0)]
        [InlineData(23, 60, -1, 999)]
        [InlineData(23, 60, -1, 1000)]
        [InlineData(23, 60, 0, -1)]
        [InlineData(23, 60, 0, 0)]
        [InlineData(23, 60, 0, 999)]
        [InlineData(23, 60, 0, 1000)]
        [InlineData(23, 60, 59, -1)]
        [InlineData(23, 60, 59, 0)]
        [InlineData(23, 60, 59, 999)]
        [InlineData(23, 60, 59, 1000)]
        [InlineData(23, 60, 60, -1)]
        [InlineData(23, 60, 60, 0)]
        [InlineData(23, 60, 60, 999)]
        [InlineData(23, 60, 60, 1000)]
        [InlineData(24, -1, -1, -1)]
        [InlineData(24, -1, -1, 0)]
        [InlineData(24, -1, -1, 999)]
        [InlineData(24, -1, -1, 1000)]
        [InlineData(24, -1, 0, -1)]
        [InlineData(24, -1, 0, 0)]
        [InlineData(24, -1, 0, 999)]
        [InlineData(24, -1, 0, 1000)]
        [InlineData(24, -1, 59, -1)]
        [InlineData(24, -1, 59, 0)]
        [InlineData(24, -1, 59, 999)]
        [InlineData(24, -1, 59, 1000)]
        [InlineData(24, -1, 60, -1)]
        [InlineData(24, -1, 60, 0)]
        [InlineData(24, -1, 60, 999)]
        [InlineData(24, -1, 60, 1000)]
        [InlineData(24, 0, -1, -1)]
        [InlineData(24, 0, -1, 0)]
        [InlineData(24, 0, -1, 999)]
        [InlineData(24, 0, -1, 1000)]
        [InlineData(24, 0, 0, -1)]
        [InlineData(24, 0, 0, 0)]
        [InlineData(24, 0, 0, 999)]
        [InlineData(24, 0, 0, 1000)]
        [InlineData(24, 0, 59, -1)]
        [InlineData(24, 0, 59, 0)]
        [InlineData(24, 0, 59, 999)]
        [InlineData(24, 0, 59, 1000)]
        [InlineData(24, 0, 60, -1)]
        [InlineData(24, 0, 60, 0)]
        [InlineData(24, 0, 60, 999)]
        [InlineData(24, 0, 60, 1000)]
        [InlineData(24, 59, -1, -1)]
        [InlineData(24, 59, -1, 0)]
        [InlineData(24, 59, -1, 999)]
        [InlineData(24, 59, -1, 1000)]
        [InlineData(24, 59, 0, -1)]
        [InlineData(24, 59, 0, 0)]
        [InlineData(24, 59, 0, 999)]
        [InlineData(24, 59, 0, 1000)]
        [InlineData(24, 59, 59, -1)]
        [InlineData(24, 59, 59, 0)]
        [InlineData(24, 59, 59, 999)]
        [InlineData(24, 59, 59, 1000)]
        [InlineData(24, 59, 60, -1)]
        [InlineData(24, 59, 60, 0)]
        [InlineData(24, 59, 60, 999)]
        [InlineData(24, 59, 60, 1000)]
        [InlineData(24, 60, -1, -1)]
        [InlineData(24, 60, -1, 0)]
        [InlineData(24, 60, -1, 999)]
        [InlineData(24, 60, -1, 1000)]
        [InlineData(24, 60, 0, -1)]
        [InlineData(24, 60, 0, 0)]
        [InlineData(24, 60, 0, 999)]
        [InlineData(24, 60, 0, 1000)]
        [InlineData(24, 60, 59, -1)]
        [InlineData(24, 60, 59, 0)]
        [InlineData(24, 60, 59, 999)]
        [InlineData(24, 60, 59, 1000)]
        [InlineData(24, 60, 60, -1)]
        [InlineData(24, 60, 60, 0)]
        [InlineData(24, 60, 60, 999)]
        [InlineData(24, 60, 60, 1000)]
        public void At_ShouldValidateParameters_WhenMillisecondIsSpecified(int hour, int minute, int second, int millisecond)
        {
            // Arrange
            var subject = default(DateTime);

            // Act
            Action action = () => subject.At(hour, minute, second, millisecond);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(0, 0, 0, 0)]
        [InlineData(0, 0, 0, 999)]
        [InlineData(0, 0, 59, 0)]
        [InlineData(0, 0, 59, 999)]
        [InlineData(0, 59, 0, 0)]
        [InlineData(0, 59, 0, 999)]
        [InlineData(0, 59, 59, 0)]
        [InlineData(0, 59, 59, 999)]
        [InlineData(23, 0, 0, 0)]
        [InlineData(23, 0, 0, 999)]
        [InlineData(23, 0, 59, 0)]
        [InlineData(23, 0, 59, 999)]
        [InlineData(23, 59, 0, 0)]
        [InlineData(23, 59, 0, 999)]
        [InlineData(23, 59, 59, 0)]
        [InlineData(23, 59, 59, 999)]
        public void At_ShouldReturnNewDateTime_WhenMillisecondIsSpecified(int hour, int minute, int second, int millisecond)
        {
            // Arrange
            var subject = default(DateTime);

            // Act
            var result = subject.At(hour, minute, second, millisecond);

            // Assert
            result.Year.Should().Be(1);
            result.Month.Should().Be(1);
            result.Day.Should().Be(1);
            result.Hour.Should().Be(hour);
            result.Minute.Should().Be(minute);
            result.Second.Should().Be(second);
            result.Millisecond.Should().Be(millisecond);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Fact]
        public void UniversalTime_ShouldReturnNewDateTime_AndSetKindToUtc()
        {
            // Arrange
            var subject = default(DateTime);

            // Act
            var result = subject.UniversalTime();

            // Assert
            result.Ticks.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Utc);
        }

        [Fact]
        public void LocalTime_ShouldReturnNewDateTime_AndSetKindToLocal()
        {
            // Arrange
            var subject = default(DateTime);

            // Act
            var result = subject.LocalTime();

            // Assert
            result.Ticks.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Local);
        }
    }
}
