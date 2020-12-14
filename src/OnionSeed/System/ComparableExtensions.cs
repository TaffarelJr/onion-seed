using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
// This allows the extension methods to be automatically available anywhere IComparable is.
namespace System
{
    /// <summary>
    /// Contains extension methods for the <see cref="IComparable"/> interface, to make it more fluent.
    /// </summary>
    public static class ComparableExtensions
    {
        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is equal to <paramref name="other"/>.
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="other">The other value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is equal to <paramref name="other"/>; otherwise, <b>false</b>.</returns>
        /// <exception cref="ArgumentException"><paramref name="other"/> is not the same type as <paramref name="source"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqualTo(this IComparable source, object other) => source is null ? other is null : source.CompareTo(other) == 0;

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is not equal to <paramref name="other"/>.
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="other">The other value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is not equal to <paramref name="other"/>; otherwise, <b>false</b>.</returns>
        /// <exception cref="ArgumentException"><paramref name="other"/> is not the same type as <paramref name="source"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNotEqualTo(this IComparable source, object other) => source is null ? !(other is null) : source.CompareTo(other) != 0;

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is less than <paramref name="other"/>.
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="other">The other value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is less than <paramref name="other"/>; otherwise, <b>false</b>.</returns>
        /// <exception cref="ArgumentException"><paramref name="other"/> is not the same type as <paramref name="source"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLessThan(this IComparable source, object other) => source is null ? !(other is null) : source.CompareTo(other) < 0;

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is less than or equal to <paramref name="other"/>.
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="other">The other value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is less than or equal to <paramref name="other"/>; otherwise, <b>false</b>.</returns>
        /// <exception cref="ArgumentException"><paramref name="other"/> is not the same type as <paramref name="source"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLessThanOrEqualTo(this IComparable source, object other) => source is null || source.CompareTo(other) <= 0;

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is greater than <paramref name="other"/>.
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="other">The other value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is greater than <paramref name="other"/>; otherwise, <b>false</b>.</returns>
        /// <exception cref="ArgumentException"><paramref name="other"/> is not the same type as <paramref name="source"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterThan(this IComparable source, object other) => !(source is null) && source.CompareTo(other) > 0;

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is greater than or equal to <paramref name="other"/>.
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="other">The other value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is greater than or equal to <paramref name="other"/>; otherwise, <b>false</b>.</returns>
        /// <exception cref="ArgumentException"><paramref name="other"/> is not the same type as <paramref name="source"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsGreaterThanOrEqualTo(this IComparable source, object other) => source is null ? other is null : source.CompareTo(other) >= 0;

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is between <paramref name="min"/> and <paramref name="max"/> (inclusive).
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="min">The minimum value being compared to <paramref name="source"/>.</param>
        /// <param name="max">The maximum value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is between <paramref name="min"/> and <paramref name="max"/> (inclusive); otherwise, <b>false</b>.</returns>
        /// <exception cref="ArgumentException"><paramref name="min"/> is not the same type as <paramref name="source"/>.
        /// -or- <paramref name="max"/> is not the same type as <paramref name="source"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="min"/> is greater than <paramref name="max"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsBetween(this IComparable source, object min, object max)
        {
            if (min is null)
                return source.IsLessThanOrEqualTo(max);

            if (!(min is IComparable comparableMin))
                throw new ArgumentException("The min value cannot be compared to the max value.", nameof(min));

            return source.IsBetween(comparableMin, max);
        }

        /// <summary>
        /// Returns a value indicating whether <paramref name="source"/> is between <paramref name="min"/> and <paramref name="max"/> (inclusive).
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="min">The minimum value being compared to <paramref name="source"/>.</param>
        /// <param name="max">The maximum value being compared to <paramref name="source"/>.</param>
        /// <returns><b>true</b> if <paramref name="source"/> is between <paramref name="min"/> and <paramref name="max"/> (inclusive); otherwise, <b>false</b>.</returns>
        /// <exception cref="ArgumentException"><paramref name="min"/> is not the same type as <paramref name="source"/>.
        /// -or- <paramref name="max"/> is not the same type as <paramref name="source"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="min"/> is greater than <paramref name="max"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsBetween(this IComparable source, IComparable min, object max)
        {
            VerifyRange(min, max);
            return source.IsGreaterThanOrEqualTo(min) && source.IsLessThanOrEqualTo(max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void VerifyRange(IComparable min, object max)
        {
            if (min.IsGreaterThan(max))
                throw new ArgumentOutOfRangeException(nameof(max), "The min value cannot be greater than the max value.");
        }
    }
}
