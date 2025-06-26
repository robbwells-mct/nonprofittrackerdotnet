using Microsoft.EntityFrameworkCore;
using NonprofitTracker.Data;
using NonprofitTracker.Models;
using NonprofitTracker.Extensions;

namespace NonprofitTracker.Tests
{
    /// <summary>
    /// Validation tests for SQLite decimal aggregation fixes
    /// These tests verify that decimal values are aggregated correctly with SQLite
    /// </summary>
    public class DecimalAggregationTests
    {
        /// <summary>
        /// Test method to validate decimal aggregation accuracy
        /// Run this in a test project or console application to verify fixes
        /// </summary>
        public static async Task ValidateDecimalAggregation()
        {
            // Create in-memory SQLite database for testing
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite("Data Source=:memory:")
                .Options;

            using var context = new ApplicationDbContext(options);
            await context.Database.EnsureCreatedAsync();

            // Create test data with precise decimal values
            var testCampaign = new Campaign
            {
                Name = "Test Campaign",
                GoalAmount = 10000.00m,
                StartDate = DateTime.Today,
                IsActive = true
            };

            var testConstituent = new Constituent
            {
                FirstName = "Test",
                LastName = "Donor",
                Email = "test@donor.com"
            };

            context.Campaigns.Add(testCampaign);
            context.Constituents.Add(testConstituent);
            await context.SaveChangesAsync();

            // Add test donations with decimal precision challenges
            var testDonations = new List<Donation>
            {
                new() { ConstituentId = testConstituent.Id, CampaignId = testCampaign.Id, Amount = 123.45m, DonationDate = DateTime.Today },
                new() { ConstituentId = testConstituent.Id, CampaignId = testCampaign.Id, Amount = 67.89m, DonationDate = DateTime.Today },
                new() { ConstituentId = testConstituent.Id, CampaignId = testCampaign.Id, Amount = 234.56m, DonationDate = DateTime.Today },
                new() { ConstituentId = testConstituent.Id, CampaignId = testCampaign.Id, Amount = 89.12m, DonationDate = DateTime.Today },
                new() { ConstituentId = testConstituent.Id, CampaignId = testCampaign.Id, Amount = 0.01m, DonationDate = DateTime.Today },
                new() { ConstituentId = testConstituent.Id, CampaignId = testCampaign.Id, Amount = 999.99m, DonationDate = DateTime.Today }
            };

            context.Donations.AddRange(testDonations);
            await context.SaveChangesAsync();

            // Expected total: 123.45 + 67.89 + 234.56 + 89.12 + 0.01 + 999.99 = 1515.02
            var expectedTotal = 1515.02m;

            // Test direct Entity Framework aggregation
            var efSum = await context.Donations
                .Where(d => d.CampaignId == testCampaign.Id)
                .SumAsync(d => d.Amount);

            // Test our SQLite-compatible aggregation
            var sqliteCompatibleSum = await context.Donations
                .Where(d => d.CampaignId == testCampaign.Id)
                .SqliteCompatibleSum(d => d.Amount);

            // Test in-memory aggregation with navigation properties
            var campaignFromDb = await context.Campaigns
                .Include(c => c.Donations)
                .FirstAsync(c => c.Id == testCampaign.Id);

            var inMemorySum = campaignFromDb.TotalRaised;

            // Validate results
            Console.WriteLine($"Expected Total: {expectedTotal:F2}");
            Console.WriteLine($"EF Core Sum: {efSum:F2}");
            Console.WriteLine($"SQLite Compatible Sum: {sqliteCompatibleSum:F2}");
            Console.WriteLine($"In-Memory Sum (Campaign.TotalRaised): {inMemorySum:F2}");

            // Check for precision issues
            var efPrecisionLoss = Math.Abs(expectedTotal - efSum);
            var sqliteCompatiblePrecisionLoss = Math.Abs(expectedTotal - sqliteCompatibleSum);
            var inMemoryPrecisionLoss = Math.Abs(expectedTotal - inMemorySum);

            Console.WriteLine($"\nPrecision Loss:");
            Console.WriteLine($"EF Core: {efPrecisionLoss:F6}");
            Console.WriteLine($"SQLite Compatible: {sqliteCompatiblePrecisionLoss:F6}");
            Console.WriteLine($"In-Memory: {inMemoryPrecisionLoss:F6}");

            // Test aggregation with filtering (amount > 0)
            var filteredSum = await context.Donations
                .Where(d => d.CampaignId == testCampaign.Id && d.Amount > 0)
                .SumAsync(d => d.Amount);

            Console.WriteLine($"\nFiltered Sum (Amount > 0): {filteredSum:F2}");

            // Validate all sums are close to expected (within 0.01 tolerance for floating point)
            var tolerance = 0.01m;
            var allValid = Math.Abs(expectedTotal - efSum) < tolerance &&
                          Math.Abs(expectedTotal - sqliteCompatibleSum) < tolerance &&
                          Math.Abs(expectedTotal - inMemorySum) < tolerance;

            Console.WriteLine($"\nAll aggregations within tolerance ({tolerance}): {allValid}");

            if (!allValid)
            {
                Console.WriteLine("WARNING: Decimal precision issues detected!");
            }
            else
            {
                Console.WriteLine("SUCCESS: All decimal aggregations are accurate!");
            }
        }
    }
}
