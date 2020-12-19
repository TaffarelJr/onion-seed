using System;

// The reason these extensions are not placed in the System namespace is to avoid conflicts with other libraries that provide simliar features.
// You must specifically add this feature as a 'using' statement in your code for it to become available.
// Also it's probably not great to add these extensions onto every integer everywhere ...
namespace OnionSeed.Utilities.FluentDate
{
    /// <summary>
    /// Contains extension methods representing each month of the year, enabling instances of <see cref="DateTime"/> to be created with a fluent syntax.
    /// </summary>
    public static class FluentMonthExtensions
    {
        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance set to the specified day of January of the specified year.
        /// </summary>
        /// <param name="day">The day (1 through 31).</param>
        /// <param name="year">The year (1 through 9999).</param>
        /// <returns>A new <see cref="DateTime"/> instance set to the specified day of January of the specified year.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="day"/> is less than 1 or greater than 31.
        /// -or- <paramref name="year"/> is less than 1 or greater than 9999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is <see cref="DateTimeKind.Unspecified"/>.</remarks>
        public static DateTime January(this int day, int year) => new DateTime(year, 1, day);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance set to the specified day of February of the specified year.
        /// </summary>
        /// <param name="day">The day (1 through 28 - or 29, depending on the year).</param>
        /// <param name="year">The year (1 through 9999).</param>
        /// <returns>A new <see cref="DateTime"/> instance set to the specified day of February of the specified year.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="day"/> is less than 1 or greater than 28 (or 29, depending on the year).
        /// -or- <paramref name="year"/> is less than 1 or greater than 9999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is <see cref="DateTimeKind.Unspecified"/>.</remarks>
        public static DateTime February(this int day, int year) => new DateTime(year, 2, day);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance set to the specified day of March of the specified year.
        /// </summary>
        /// <param name="day">The day (1 through 31).</param>
        /// <param name="year">The year (1 through 9999).</param>
        /// <returns>A new <see cref="DateTime"/> instance set to the specified day of March of the specified year.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="day"/> is less than 1 or greater than 31.
        /// -or- <paramref name="year"/> is less than 1 or greater than 9999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is <see cref="DateTimeKind.Unspecified"/>.</remarks>
        public static DateTime March(this int day, int year) => new DateTime(year, 3, day);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance set to the specified day of April of the specified year.
        /// </summary>
        /// <param name="day">The day (1 through 30).</param>
        /// <param name="year">The year (1 through 9999).</param>
        /// <returns>A new <see cref="DateTime"/> instance set to the specified day of April of the specified year.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="day"/> is less than 1 or greater than 30.
        /// -or- <paramref name="year"/> is less than 1 or greater than 9999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is <see cref="DateTimeKind.Unspecified"/>.</remarks>
        public static DateTime April(this int day, int year) => new DateTime(year, 4, day);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance set to the specified day of May of the specified year.
        /// </summary>
        /// <param name="day">The day (1 through 31).</param>
        /// <param name="year">The year (1 through 9999).</param>
        /// <returns>A new <see cref="DateTime"/> instance set to the specified day of May of the specified year.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="day"/> is less than 1 or greater than 31.
        /// -or- <paramref name="year"/> is less than 1 or greater than 9999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is <see cref="DateTimeKind.Unspecified"/>.</remarks>
        public static DateTime May(this int day, int year) => new DateTime(year, 5, day);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance set to the specified day of June of the specified year.
        /// </summary>
        /// <param name="day">The day (1 through 30).</param>
        /// <param name="year">The year (1 through 9999).</param>
        /// <returns>A new <see cref="DateTime"/> instance set to the specified day of June of the specified year.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="day"/> is less than 1 or greater than 30.
        /// -or- <paramref name="year"/> is less than 1 or greater than 9999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is <see cref="DateTimeKind.Unspecified"/>.</remarks>
        public static DateTime June(this int day, int year) => new DateTime(year, 6, day);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance set to the specified day of July of the specified year.
        /// </summary>
        /// <param name="day">The day (1 through 31).</param>
        /// <param name="year">The year (1 through 9999).</param>
        /// <returns>A new <see cref="DateTime"/> instance set to the specified day of July of the specified year.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="day"/> is less than 1 or greater than 31.
        /// -or- <paramref name="year"/> is less than 1 or greater than 9999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is <see cref="DateTimeKind.Unspecified"/>.</remarks>
        public static DateTime July(this int day, int year) => new DateTime(year, 7, day);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance set to the specified day of August of the specified year.
        /// </summary>
        /// <param name="day">The day (1 through 31).</param>
        /// <param name="year">The year (1 through 9999).</param>
        /// <returns>A new <see cref="DateTime"/> instance set to the specified day of August of the specified year.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="day"/> is less than 1 or greater than 31.
        /// -or- <paramref name="year"/> is less than 1 or greater than 9999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is <see cref="DateTimeKind.Unspecified"/>.</remarks>
        public static DateTime August(this int day, int year) => new DateTime(year, 8, day);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance set to the specified day of September of the specified year.
        /// </summary>
        /// <param name="day">The day (1 through 30).</param>
        /// <param name="year">The year (1 through 9999).</param>
        /// <returns>A new <see cref="DateTime"/> instance set to the specified day of September of the specified year.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="day"/> is less than 1 or greater than 30.
        /// -or- <paramref name="year"/> is less than 1 or greater than 9999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is <see cref="DateTimeKind.Unspecified"/>.</remarks>
        public static DateTime September(this int day, int year) => new DateTime(year, 9, day);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance set to the specified day of October of the specified year.
        /// </summary>
        /// <param name="day">The day (1 through 31).</param>
        /// <param name="year">The year (1 through 9999).</param>
        /// <returns>A new <see cref="DateTime"/> instance set to the specified day of October of the specified year.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="day"/> is less than 1 or greater than 31.
        /// -or- <paramref name="year"/> is less than 1 or greater than 9999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is <see cref="DateTimeKind.Unspecified"/>.</remarks>
        public static DateTime October(this int day, int year) => new DateTime(year, 10, day);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance set to the specified day of November of the specified year.
        /// </summary>
        /// <param name="day">The day (1 through 30).</param>
        /// <param name="year">The year (1 through 9999).</param>
        /// <returns>A new <see cref="DateTime"/> instance set to the specified day of November of the specified year.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="day"/> is less than 1 or greater than 30.
        /// -or- <paramref name="year"/> is less than 1 or greater than 9999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is <see cref="DateTimeKind.Unspecified"/>.</remarks>
        public static DateTime November(this int day, int year) => new DateTime(year, 11, day);

        /// <summary>
        /// Returns a new <see cref="DateTime"/> instance set to the specified day of December of the specified year.
        /// </summary>
        /// <param name="day">The day (1 through 31).</param>
        /// <param name="year">The year (1 through 9999).</param>
        /// <returns>A new <see cref="DateTime"/> instance set to the specified day of December of the specified year.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="day"/> is less than 1 or greater than 31.
        /// -or- <paramref name="year"/> is less than 1 or greater than 9999.</exception>
        /// <remarks>The <see cref="DateTime.Kind"/> of the return value is <see cref="DateTimeKind.Unspecified"/>.</remarks>
        public static DateTime December(this int day, int year) => new DateTime(year, 12, day);
    }
}
