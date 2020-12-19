using System;
using FluentAssertions;
using Xunit;

namespace OnionSeed.Utilities.FluentDate
{
    public class FluentMonthExtensionsTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 9999)]
        [InlineData(0, 10000)]
        [InlineData(1, 0)]
        [InlineData(1, 10000)]
        [InlineData(31, 0)]
        [InlineData(31, 10000)]
        [InlineData(32, 0)]
        [InlineData(32, 1)]
        [InlineData(32, 9999)]
        [InlineData(32, 10000)]
        public void January_ShouldValidateParameters(int day, int year)
        {
            // Act
            Action action = () => day.January(year);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 9999)]
        [InlineData(31, 1)]
        [InlineData(31, 9999)]
        public void January_ShouldReturnNewDateTime(int day, int year)
        {
            // Act
            var result = day.January(year);

            // Assert
            result.Year.Should().Be(year);
            result.Month.Should().Be(1);
            result.Day.Should().Be(day);
            result.Hour.Should().Be(0);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 9999)]
        [InlineData(0, 10000)]
        [InlineData(1, 0)]
        [InlineData(1, 10000)]
        [InlineData(28, 0)]
        [InlineData(28, 10000)]
        [InlineData(29, 0)]
        [InlineData(29, 1)] // not a leap year
        [InlineData(29, 2)] // not a leap year
        [InlineData(29, 3)] // not a leap year
        [InlineData(29, 9997)] // not a leap year
        [InlineData(29, 9998)] // not a leap year
        [InlineData(29, 9999)] // not a leap year
        [InlineData(29, 10000)]
        [InlineData(30, 0)]
        [InlineData(30, 1)]
        [InlineData(30, 9999)]
        [InlineData(30, 10000)]
        public void February_ShouldValidateParameters(int day, int year)
        {
            // Act
            Action action = () => day.February(year);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 9999)]
        [InlineData(28, 1)]
        [InlineData(28, 9999)]
        [InlineData(29, 4)] // leap year
        [InlineData(29, 9996)] // leap year
        public void February_ShouldReturnNewDateTime(int day, int year)
        {
            // Act
            var result = day.February(year);

            // Assert
            result.Year.Should().Be(year);
            result.Month.Should().Be(2);
            result.Day.Should().Be(day);
            result.Hour.Should().Be(0);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 9999)]
        [InlineData(0, 10000)]
        [InlineData(1, 0)]
        [InlineData(1, 10000)]
        [InlineData(31, 0)]
        [InlineData(31, 10000)]
        [InlineData(32, 0)]
        [InlineData(32, 1)]
        [InlineData(32, 9999)]
        [InlineData(32, 10000)]
        public void March_ShouldValidateParameters(int day, int year)
        {
            // Act
            Action action = () => day.March(year);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 9999)]
        [InlineData(31, 1)]
        [InlineData(31, 9999)]
        public void March_ShouldReturnNewDateTime(int day, int year)
        {
            // Act
            var result = day.March(year);

            // Assert
            result.Year.Should().Be(year);
            result.Month.Should().Be(3);
            result.Day.Should().Be(day);
            result.Hour.Should().Be(0);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 9999)]
        [InlineData(0, 10000)]
        [InlineData(1, 0)]
        [InlineData(1, 10000)]
        [InlineData(30, 0)]
        [InlineData(30, 10000)]
        [InlineData(31, 0)]
        [InlineData(31, 1)]
        [InlineData(31, 9999)]
        [InlineData(31, 10000)]
        public void April_ShouldValidateParameters(int day, int year)
        {
            // Act
            Action action = () => day.April(year);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 9999)]
        [InlineData(30, 1)]
        [InlineData(30, 9999)]
        public void April_ShouldReturnNewDateTime(int day, int year)
        {
            // Act
            var result = day.April(year);

            // Assert
            result.Year.Should().Be(year);
            result.Month.Should().Be(4);
            result.Day.Should().Be(day);
            result.Hour.Should().Be(0);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 9999)]
        [InlineData(0, 10000)]
        [InlineData(1, 0)]
        [InlineData(1, 10000)]
        [InlineData(31, 0)]
        [InlineData(31, 10000)]
        [InlineData(32, 0)]
        [InlineData(32, 1)]
        [InlineData(32, 9999)]
        [InlineData(32, 10000)]
        public void May_ShouldValidateParameters(int day, int year)
        {
            // Act
            Action action = () => day.May(year);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 9999)]
        [InlineData(31, 1)]
        [InlineData(31, 9999)]
        public void May_ShouldReturnNewDateTime(int day, int year)
        {
            // Act
            var result = day.May(year);

            // Assert
            result.Year.Should().Be(year);
            result.Month.Should().Be(5);
            result.Day.Should().Be(day);
            result.Hour.Should().Be(0);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 9999)]
        [InlineData(0, 10000)]
        [InlineData(1, 0)]
        [InlineData(1, 10000)]
        [InlineData(30, 0)]
        [InlineData(30, 10000)]
        [InlineData(31, 0)]
        [InlineData(31, 1)]
        [InlineData(31, 9999)]
        [InlineData(31, 10000)]
        public void June_ShouldValidateParameters(int day, int year)
        {
            // Act
            Action action = () => day.June(year);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 9999)]
        [InlineData(30, 1)]
        [InlineData(30, 9999)]
        public void June_ShouldReturnNewDateTime(int day, int year)
        {
            // Act
            var result = day.June(year);

            // Assert
            result.Year.Should().Be(year);
            result.Month.Should().Be(6);
            result.Day.Should().Be(day);
            result.Hour.Should().Be(0);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 9999)]
        [InlineData(0, 10000)]
        [InlineData(1, 0)]
        [InlineData(1, 10000)]
        [InlineData(31, 0)]
        [InlineData(31, 10000)]
        [InlineData(32, 0)]
        [InlineData(32, 1)]
        [InlineData(32, 9999)]
        [InlineData(32, 10000)]
        public void July_ShouldValidateParameters(int day, int year)
        {
            // Act
            Action action = () => day.July(year);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 9999)]
        [InlineData(31, 1)]
        [InlineData(31, 9999)]
        public void July_ShouldReturnNewDateTime(int day, int year)
        {
            // Act
            var result = day.July(year);

            // Assert
            result.Year.Should().Be(year);
            result.Month.Should().Be(7);
            result.Day.Should().Be(day);
            result.Hour.Should().Be(0);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 9999)]
        [InlineData(0, 10000)]
        [InlineData(1, 0)]
        [InlineData(1, 10000)]
        [InlineData(31, 0)]
        [InlineData(31, 10000)]
        [InlineData(32, 0)]
        [InlineData(32, 1)]
        [InlineData(32, 9999)]
        [InlineData(32, 10000)]
        public void August_ShouldValidateParameters(int day, int year)
        {
            // Act
            Action action = () => day.August(year);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 9999)]
        [InlineData(31, 1)]
        [InlineData(31, 9999)]
        public void August_ShouldReturnNewDateTime(int day, int year)
        {
            // Act
            var result = day.August(year);

            // Assert
            result.Year.Should().Be(year);
            result.Month.Should().Be(8);
            result.Day.Should().Be(day);
            result.Hour.Should().Be(0);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 9999)]
        [InlineData(0, 10000)]
        [InlineData(1, 0)]
        [InlineData(1, 10000)]
        [InlineData(30, 0)]
        [InlineData(30, 10000)]
        [InlineData(31, 0)]
        [InlineData(31, 1)]
        [InlineData(31, 9999)]
        [InlineData(31, 10000)]
        public void September_ShouldValidateParameters(int day, int year)
        {
            // Act
            Action action = () => day.September(year);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 9999)]
        [InlineData(30, 1)]
        [InlineData(30, 9999)]
        public void September_ShouldReturnNewDateTime(int day, int year)
        {
            // Act
            var result = day.September(year);

            // Assert
            result.Year.Should().Be(year);
            result.Month.Should().Be(9);
            result.Day.Should().Be(day);
            result.Hour.Should().Be(0);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 9999)]
        [InlineData(0, 10000)]
        [InlineData(1, 0)]
        [InlineData(1, 10000)]
        [InlineData(31, 0)]
        [InlineData(31, 10000)]
        [InlineData(32, 0)]
        [InlineData(32, 1)]
        [InlineData(32, 9999)]
        [InlineData(32, 10000)]
        public void October_ShouldValidateParameters(int day, int year)
        {
            // Act
            Action action = () => day.October(year);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 9999)]
        [InlineData(31, 1)]
        [InlineData(31, 9999)]
        public void October_ShouldReturnNewDateTime(int day, int year)
        {
            // Act
            var result = day.October(year);

            // Assert
            result.Year.Should().Be(year);
            result.Month.Should().Be(10);
            result.Day.Should().Be(day);
            result.Hour.Should().Be(0);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 9999)]
        [InlineData(0, 10000)]
        [InlineData(1, 0)]
        [InlineData(1, 10000)]
        [InlineData(30, 0)]
        [InlineData(30, 10000)]
        [InlineData(31, 0)]
        [InlineData(31, 1)]
        [InlineData(31, 9999)]
        [InlineData(31, 10000)]
        public void November_ShouldValidateParameters(int day, int year)
        {
            // Act
            Action action = () => day.November(year);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 9999)]
        [InlineData(30, 1)]
        [InlineData(30, 9999)]
        public void November_ShouldReturnNewDateTime(int day, int year)
        {
            // Act
            var result = day.November(year);

            // Assert
            result.Year.Should().Be(year);
            result.Month.Should().Be(11);
            result.Day.Should().Be(day);
            result.Hour.Should().Be(0);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 9999)]
        [InlineData(0, 10000)]
        [InlineData(1, 0)]
        [InlineData(1, 10000)]
        [InlineData(31, 0)]
        [InlineData(31, 10000)]
        [InlineData(32, 0)]
        [InlineData(32, 1)]
        [InlineData(32, 9999)]
        [InlineData(32, 10000)]
        public void December_ShouldValidateParameters(int day, int year)
        {
            // Act
            Action action = () => day.December(year);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 9999)]
        [InlineData(31, 1)]
        [InlineData(31, 9999)]
        public void December_ShouldReturnNewDateTime(int day, int year)
        {
            // Act
            var result = day.December(year);

            // Assert
            result.Year.Should().Be(year);
            result.Month.Should().Be(12);
            result.Day.Should().Be(day);
            result.Hour.Should().Be(0);
            result.Minute.Should().Be(0);
            result.Second.Should().Be(0);
            result.Millisecond.Should().Be(0);
            result.Kind.Should().Be(DateTimeKind.Unspecified);
        }
    }
}
