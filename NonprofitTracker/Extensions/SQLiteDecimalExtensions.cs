using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace NonprofitTracker.Extensions
{
    public static class SQLiteDecimalExtensions
    {
        /// <summary>
        /// In-memory decimal sum with null handling for navigation properties
        /// Filters out negative and zero amounts automatically
        /// </summary>
        public static decimal SafeSum<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, decimal> selector)
        {
            if (source == null || !source.Any())
                return 0m;

            return source
                .Where(x => x != null)
                .Select(selector)
                .Where(amount => amount > 0)
                .Sum();
        }

        /// <summary>
        /// In-memory decimal average with null handling
        /// Filters out negative and zero amounts automatically
        /// </summary>
        public static decimal SafeAverage<TSource>(
            this IEnumerable<TSource> source,
            Func<TSource, decimal> selector)
        {
            if (source == null || !source.Any())
                return 0m;

            var validAmounts = source
                .Where(x => x != null)
                .Select(selector)
                .Where(amount => amount > 0)
                .ToList();

            return validAmounts.Any() ? validAmounts.Average() : 0m;
        }

        /// <summary>
        /// SQLite-compatible decimal sum that loads data to memory first
        /// Use this when you need to sum decimals with SQLite database
        /// </summary>
        public static async Task<decimal> SqliteCompatibleSum<TSource>(
            this IQueryable<TSource> source,
            Expression<Func<TSource, decimal>> selector,
            CancellationToken cancellationToken = default)
        {
            var compiled = selector.Compile();
            var data = await source.ToListAsync(cancellationToken);
            return data.SafeSum(compiled);
        }

        /// <summary>
        /// SQLite-compatible decimal average that loads data to memory first
        /// Use this when you need to average decimals with SQLite database
        /// </summary>
        public static async Task<decimal> SqliteCompatibleAverage<TSource>(
            this IQueryable<TSource> source,
            Expression<Func<TSource, decimal>> selector,
            CancellationToken cancellationToken = default)
        {
            var compiled = selector.Compile();
            var data = await source.ToListAsync(cancellationToken);
            return data.SafeAverage(compiled);
        }
    }
}
