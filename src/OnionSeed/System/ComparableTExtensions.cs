using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
// This allows the extension methods to be automatically available anywhere IComparable<T> is.
namespace System
{
    /// <summary>
    /// Contains extension methods for the <see cref="IComparable{T}"/> interface, to make it more fluent.
    /// </summary>
    public static class ComparableTExtensions
    {
        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is equal to <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects being compared.</typeparam>
        /// <param name="source">The source value.</param>
        /// <param name="other">The other value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is equal to <paramref name="other"/>; otherwise, <b>false</b>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqualTo<T>(this IComparable<T> source, T other) => source is null ? other == null : source.CompareTo(other) == 0;

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is not equal to <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects being compared.</typeparam>
        /// <param name="source">The source value.</param>
        /// <param name="other">The other value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is not equal to <paramref name="other"/>; otherwise, <b>false</b>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNotEqualTo<T>(this IComparable<T> source, T other) => source is null ? !(other == null) : source.CompareTo(other) != 0;

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is less than <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects being compared.</typeparam>
        /// <param name="source">The source value.</param>
        /// <param name="other">The other value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is less than <paramref name="other"/>; otherwise, <b>false</b>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLessThan<T>(this IComparable<T> source, T other) => source is null ? !(other == null) : source.CompareTo(other) < 0;

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is less than or equal to <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects being compared.</typeparam>
        /// <param name="source">The source value.</param>
        /// <param name="other">The other value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is less than or equal to <paramref name="other"/>; otherwise, <b>false</b>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLessThanOrEqualTo<T>(this IComparable<T> source, T other) => source is null || source.CompareTo(other) <= 0;

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is greater than <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects being compared.</typeparam>
        /// <param name="source">The source value.</param>
        /// <param name="other">The other value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is greater than <paramref name="other"/>; otherwise, <b>false</b>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterThan<T>(this IComparable<T> source, T other) => !(source is null) && source.CompareTo(other) > 0;

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is greater than or equal to <paramref name="other"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects being compared.</typeparam>
        /// <param name="source">The source value.</param>
        /// <param name="other">The other value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is greater than or equal to <paramref name="other"/>; otherwise, <b>false</b>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterThanOrEqualTo<T>(this IComparable<T> source, T other) => source is null ? other == null : source.CompareTo(other) >= 0;

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is between <paramref name="min"/> and <paramref name="max"/> (inclusive).
        /// </summary>
        /// <typeparam name="T">The type of the objects being compared.</typeparam>
        /// <param name="source">The source value.</param>
        /// <param name="min">The minimum value being compared to <paramref name="source"/>.</param>
        /// <param name="max">The maximum value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is between <paramref name="min"/> and <paramref name="max"/> (inclusive); otherwise, <b>false</b>.</returns>
        /// -or- <paramref name="max"/> is not the same type as <paramref name="source"/>.
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="min"/> is greater than <paramref name="max"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsBetween<T>(this IComparable<T> source, T min, T max)
            where T : IComparable<T>
        {
            VerifyRange(min, max);
            return source.IsGreaterThanOrEqualTo(min) && source.IsLessThanOrEqualTo(max);
        }

        /// <summary>
        /// Returns the larger of either <paramref name="source"/> or <paramref name="min"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects being compared.</typeparam>
        /// <param name="source">The source value.</param>
        /// <param name="min">The minimum value being compared to <paramref name="source"/>.</param>
        /// <returns><paramref name="min"/>, if <paramref name="source"/> is less than <paramref name="min"/>; otherwise, <paramref name="source"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConstrainToMin<T>(this T source, T min)
            where T : IComparable<T> => source.IsLessThan(min) ? min : source;

        /// <summary>
        /// Returns the smaller of either <paramref name="source"/> or <paramref name="max"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects being compared.</typeparam>
        /// <param name="source">The source value.</param>
        /// <param name="max">The maximum value being compared to <paramref name="source"/>.</param>
        /// <returns><paramref name="max"/>, if <paramref name="source"/> is greater than <paramref name="max"/>; otherwise, <paramref name="source"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConstrainToMax<T>(this T source, T max)
            where T : IComparable<T> => source.IsGreaterThan(max) ? max : source;

        /// <summary>
        /// Gets the larger of either <paramref name="source"/> or <paramref name="min"/>
        /// then returns the smaller of either that number or <paramref name="max"/>.
        /// </summary>
        /// <typeparam name="T">The type of the objects being compared.</typeparam>
        /// <param name="source">The source value.</param>
        /// <param name="min">The minimum value being compared to <paramref name="source"/>.</param>
        /// <param name="max">The maximum value being compared to <paramref name="source"/>.</param>
        /// <returns><paramref name="min"/> if <paramref name="source"/> is less than <paramref name="min"/>,
        /// or <paramref name="max"/> if <paramref name="source"/> is greater than <paramref name="max"/>; otherwise, <paramref name="source"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="min"/> is greater than <paramref name="max"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConstrainTo<T>(this T source, T min, T max)
            where T : IComparable<T>
        {
            VerifyRange(min, max);
            return source.ConstrainToMin(min).ConstrainToMax(max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void VerifyRange<T>(IComparable<T> min, T max)
        {
            if (min.IsGreaterThan(max))
                throw new ArgumentOutOfRangeException(nameof(max), "The min value cannot be greater than the max value.");
        }
    }
}
