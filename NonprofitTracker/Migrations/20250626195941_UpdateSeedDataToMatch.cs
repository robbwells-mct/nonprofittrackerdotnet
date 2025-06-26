using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonprofitTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataToMatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5221), new DateTime(2025, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5226), new DateTime(2025, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 10, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5499), new DateTime(2024, 10, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 8, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5514), new DateTime(2024, 8, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 12, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5721), new DateTime(2024, 12, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5728), new DateTime(2024, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 2, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5734), new DateTime(2025, 2, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5739), new DateTime(2024, 11, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 9, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5744), new DateTime(2024, 9, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5749), new DateTime(2025, 1, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 3, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5755), new DateTime(2025, 3, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 7, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5760), new DateTime(2024, 7, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5872), new DateTime(2025, 2, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5872), new DateTime(2025, 2, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5864), new DateTime(2025, 2, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5874), new DateTime(2025, 2, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5881), new DateTime(2025, 4, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5881), new DateTime(2025, 4, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5879), new DateTime(2025, 4, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5882), new DateTime(2025, 4, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5889), new DateTime(2025, 3, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5888), new DateTime(2025, 3, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5887), new DateTime(2025, 3, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5889), new DateTime(2025, 3, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5896), new DateTime(2025, 5, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5895), new DateTime(2025, 5, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5894), new DateTime(2025, 5, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5897), new DateTime(2025, 5, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 1, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5907), new DateTime(2025, 1, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5902), new DateTime(2025, 1, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5901), new DateTime(2025, 1, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5907), new DateTime(2025, 1, 27, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 2, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 2, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5912), new DateTime(2025, 2, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5914), new DateTime(2025, 2, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5920), new DateTime(2025, 3, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5920), new DateTime(2025, 3, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5918), new DateTime(2025, 3, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5921), new DateTime(2025, 3, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 8, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5928), new DateTime(2024, 12, 8, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5927), new DateTime(2024, 12, 8, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5926), new DateTime(2024, 12, 8, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5928), new DateTime(2024, 12, 8, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5935), new DateTime(2025, 4, 12, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5934), new DateTime(2025, 4, 12, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5933), new DateTime(2025, 4, 12, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5935), new DateTime(2025, 4, 12, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 12, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5942), new DateTime(2025, 5, 12, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5942), new DateTime(2025, 5, 12, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5941), new DateTime(2025, 5, 12, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5943), new DateTime(2025, 5, 12, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 12, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5949), new DateTime(2024, 12, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5948), new DateTime(2024, 12, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 12, 28, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 18, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5957), new DateTime(2025, 3, 18, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5956), new DateTime(2025, 3, 18, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5955), new DateTime(2025, 3, 18, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5958), new DateTime(2025, 3, 18, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 7, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5966), new DateTime(2025, 5, 7, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5965), new DateTime(2025, 5, 7, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5962), new DateTime(2025, 5, 7, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5966), new DateTime(2025, 5, 7, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5973), new DateTime(2024, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5972), new DateTime(2024, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5971), new DateTime(2024, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5973), new DateTime(2024, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 1, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5980), new DateTime(2025, 6, 1, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5979), new DateTime(2025, 6, 1, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5978), new DateTime(2025, 6, 1, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5980), new DateTime(2025, 6, 1, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5987), new DateTime(2025, 4, 7, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5986), new DateTime(2025, 4, 7, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5985), new DateTime(2025, 4, 7, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5987), new DateTime(2025, 4, 7, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 11, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5994), new DateTime(2025, 6, 11, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5993), new DateTime(2025, 6, 11, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5992), new DateTime(2025, 6, 11, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5994), new DateTime(2025, 6, 11, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(6001), new DateTime(2024, 11, 18, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(6000), new DateTime(2024, 11, 18, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5999), new DateTime(2024, 11, 18, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(6001), new DateTime(2024, 11, 18, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5441), new DateTime(2025, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5445), new DateTime(2025, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5448), new DateTime(2025, 6, 26, 19, 59, 39, 598, DateTimeKind.Utc).AddTicks(5449) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4023), new DateTime(2025, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4028), new DateTime(2025, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 10, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4256), new DateTime(2024, 10, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 8, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4272), new DateTime(2024, 8, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 12, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4277), new DateTime(2024, 12, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4283), new DateTime(2024, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4288), new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4294), new DateTime(2024, 11, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 9, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4299), new DateTime(2024, 9, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4403), new DateTime(2025, 1, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 3, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4409), new DateTime(2025, 3, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 7, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4414), new DateTime(2024, 7, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4499), new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4498), new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4492), new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4500), new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4508), new DateTime(2025, 4, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4507), new DateTime(2025, 4, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4506), new DateTime(2025, 4, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4509), new DateTime(2025, 4, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4516), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4515), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4513), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4516), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4523), new DateTime(2025, 5, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4523), new DateTime(2025, 5, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4521), new DateTime(2025, 5, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4524), new DateTime(2025, 5, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 1, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4531), new DateTime(2025, 1, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4530), new DateTime(2025, 1, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4529), new DateTime(2025, 1, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4531), new DateTime(2025, 1, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4538), new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4537), new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4536), new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4539), new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4545), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4545), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4543), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4546), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 8, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4553), new DateTime(2024, 12, 8, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4552), new DateTime(2024, 12, 8, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4551), new DateTime(2024, 12, 8, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4553), new DateTime(2024, 12, 8, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4560), new DateTime(2025, 4, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4559), new DateTime(2025, 4, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4558), new DateTime(2025, 4, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4561), new DateTime(2025, 4, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4567), new DateTime(2025, 5, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4567), new DateTime(2025, 5, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4565), new DateTime(2025, 5, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4568), new DateTime(2025, 5, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 12, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 12, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4574), new DateTime(2024, 12, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4573), new DateTime(2024, 12, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 12, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4582), new DateTime(2025, 3, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4581), new DateTime(2025, 3, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4580), new DateTime(2025, 3, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4582), new DateTime(2025, 3, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 5, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4589), new DateTime(2025, 5, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4588), new DateTime(2025, 5, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4587), new DateTime(2025, 5, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4590), new DateTime(2025, 5, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4596), new DateTime(2024, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4596), new DateTime(2024, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4594), new DateTime(2024, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4597), new DateTime(2024, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 1, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4604), new DateTime(2025, 6, 1, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4603), new DateTime(2025, 6, 1, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4602), new DateTime(2025, 6, 1, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4605), new DateTime(2025, 6, 1, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4611), new DateTime(2025, 4, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4611), new DateTime(2025, 4, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4610), new DateTime(2025, 4, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4612), new DateTime(2025, 4, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 11, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4619), new DateTime(2025, 6, 11, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4618), new DateTime(2025, 6, 11, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4617), new DateTime(2025, 6, 11, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4619), new DateTime(2025, 6, 11, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 11, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4626), new DateTime(2024, 11, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4625), new DateTime(2024, 11, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4624), new DateTime(2024, 11, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4627), new DateTime(2024, 11, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4205), new DateTime(2025, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4209), new DateTime(2025, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4212), new DateTime(2025, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4213) });
        }
    }
}
