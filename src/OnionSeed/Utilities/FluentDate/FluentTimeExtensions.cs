using System;

// The reason these extensions are not placed in the System namespace is to avoid conflicts with other libraries that provide a simliar feature.
// You must specifically add this feature as a 'using' statement in your code for it to become available.
namespace OnionSeed.Utilities.FluentDate
{
    /// <summary>
    /// Contains extension methods representing the time of day, enabling the time portion of a <see cref="DateTime"/> to be set with a fluent syntax.
    /// </summary>
    public static class FluentTimeExtensions
    {
        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance using the date portion of the given <see cref="DateTime"/>, but with the time portion configured as specified.
        /// </summary>
        /// <param name="source">The original <see cref="DateTime"/> value, whose time portion is to be set.</param>
        /// <param name="hour">The desired hour (0 through 23).</param>
        /// <returns>A new <see cref="DateTime"/> instance using the date portion of the given <see cref="DateTime"/>, but with the time portion configured as specified.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="hour"/> is less than 0 or greater than 23.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is the same as the original <see cref="DateTime"/>.
        /// <para>This method leaves the extra ticks value set to zero.</para></remarks>
        public static DateTime At(this DateTime source, int hour) => source.At(hour, 0);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance using the date portion of the given <see cref="DateTime"/>, but with the time portion configured as specified.
        /// </summary>
        /// <param name="source">The original <see cref="DateTime"/> value, whose time portion is to be set.</param>
        /// <param name="hour">The desired hour (0 through 23).</param>
        /// <param name="minutes">The desired number of minutes (0 through 59).</param>
        /// <returns>A new <see cref="DateTime"/> instance using the date portion of the given <see cref="DateTime"/>, but with the time portion configured as specified.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="hour"/> is less than 0 or greater than 23.
        /// -or- <paramref name="minutes"/> is less than 0 or greater than 59.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is the same as the original <see cref="DateTime"/>.
        /// <para>This method leaves the extra ticks value set to zero.</para></remarks>
        public static DateTime At(this DateTime source, int hour, int minutes) => source.At(hour, minutes, 0);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance using the date portion of the given <see cref="DateTime"/>, but with the time portion configured as specified.
        /// </summary>
        /// <param name="source">The original <see cref="DateTime"/> value, whose time portion is to be set.</param>
        /// <param name="hour">The desired hour (0 through 23).</param>
        /// <param name="minutes">The desired number of minutes (0 through 59).</param>
        /// <param name="seconds">The desired number of seconds (0 through 59).</param>
        /// <returns>A new <see cref="DateTime"/> instance using the date portion of the given <see cref="DateTime"/>, but with the time portion configured as specified.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="hour"/> is less than 0 or greater than 23.
        /// -or- <paramref name="minutes"/> is less than 0 or greater than 59.
        /// -or- <paramref name="seconds"/> is less than 0 or greater than 59.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is the same as the original <see cref="DateTime"/>.
        /// <para>This method leaves the extra ticks value set to zero.</para></remarks>
        public static DateTime At(this DateTime source, int hour, int minutes, int seconds) => source.At(hour, minutes, seconds, 0);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance using the date portion of the given <see cref="DateTime"/>, but with the time portion configured as specified.
        /// </summary>
        /// <param name="source">The original <see cref="DateTime"/> value, whose time portion is to be set.</param>
        /// <param name="hour">The desired hour (0 through 23).</param>
        /// <param name="minutes">The desired number of minutes (0 through 59).</param>
        /// <param name="seconds">The desired number of seconds (0 through 59).</param>
        /// <param name="milliseconds">The desired number of milliseconds (0 through 999).</param>
        /// <returns>A new <see cref="DateTime"/> instance using the date portion of the given <see cref="DateTime"/>, but with the time portion configured as specified.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="hour"/> is less than 0 or greater than 23.
        /// -or- <paramref name="minutes"/> is less than 0 or greater than 59.
        /// -or- <paramref name="seconds"/> is less than 0 or greater than 59.
        /// -or- <paramref name="milliseconds"/> is less than 0 or greater than 999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is the same as the original <see cref="DateTime"/>.
        /// <para>This method leaves the extra ticks value set to zero.</para></remarks>
        public static DateTime At(this DateTime source, int hour, int minutes, int seconds, int milliseconds) =>
            new DateTime(source.Year, source.Month, source.Day, hour, minutes, seconds, milliseconds, source.Kind);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance using the date and time portions of the given <see cref="DateTime"/>, but with the kind set to UTC time.
        /// </summary>
        /// <param name="source">The original <see cref="DateTime"/> value, whose kind is to be set.</param>
        /// <returns>A new <see cref="DateTime"/> instance using the date and time portions of the given <see cref="DateTime"/>, but with the kind set to UTC time.</returns>
        /// <remarks>No conversion is performed; the <see cref="DateTime"/> retains it's current values. Only the kind changes.</remarks>
        public static DateTime UniversalTime(this DateTime source) => new DateTime(source.Ticks, DateTimeKind.Utc);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance using the date and time portions of the given <see cref="DateTime"/>, but with the kind set to local time.
        /// </summary>
        /// <param name="source">The original <see cref="DateTime"/> value, whose kind is to be set.</param>
        /// <returns>A new <see cref="DateTime"/> instance using the date and time portions of the given <see cref="DateTime"/>, but with the kind set to local time.</returns>
        /// <remarks>No conversion is performed; the <see cref="DateTime"/> retains it's current values. Only the kind changes.</remarks>
        public static DateTime LocalTime(this DateTime source) => new DateTime(source.Ticks, DateTimeKind.Local);
    }
}
