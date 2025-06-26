using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonprofitTracker.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4516), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4515), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4513), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4516), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 5, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4523), new DateTime(2025, 5, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4523), new DateTime(2025, 5, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4521), new DateTime(2025, 5, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4524), new DateTime(2025, 5, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "DonationType", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 1, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4531), new DateTime(2025, 1, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4530), new DateTime(2025, 1, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4529), 1, new DateTime(2025, 1, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4531), new DateTime(2025, 1, 27, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "DonationType", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4538), new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4537), new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4536), 1, new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4539), new DateTime(2025, 2, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "DonationType", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4545), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4545), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4543), 1, new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4546), new DateTime(2025, 3, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 8, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4553), new DateTime(2024, 12, 8, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4552), new DateTime(2024, 12, 8, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4551), new DateTime(2024, 12, 8, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4553), new DateTime(2024, 12, 8, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 4, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4560), new DateTime(2025, 4, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4559), new DateTime(2025, 4, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4558), new DateTime(2025, 4, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4561), new DateTime(2025, 4, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 5, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4567), new DateTime(2025, 5, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4567), new DateTime(2025, 5, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4565), new DateTime(2025, 5, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4568), new DateTime(2025, 5, 12, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 12, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 12, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4574), new DateTime(2024, 12, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4573), new DateTime(2024, 12, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 12, 28, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 3, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4582), new DateTime(2025, 3, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4581), new DateTime(2025, 3, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4580), new DateTime(2025, 3, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4582), new DateTime(2025, 3, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4583) });

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
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4596), new DateTime(2024, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4596), new DateTime(2024, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4594), new DateTime(2024, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4597), new DateTime(2024, 6, 26, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 6, 1, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4604), new DateTime(2025, 6, 1, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4603), new DateTime(2025, 6, 1, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4602), new DateTime(2025, 6, 1, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4605), new DateTime(2025, 6, 1, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 4, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4611), new DateTime(2025, 4, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4611), new DateTime(2025, 4, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4610), new DateTime(2025, 4, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4612), new DateTime(2025, 4, 7, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4613) });

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
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 11, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4626), new DateTime(2024, 11, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4625), new DateTime(2024, 11, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4624), new DateTime(2024, 11, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4627), new DateTime(2024, 11, 18, 19, 39, 50, 195, DateTimeKind.Utc).AddTicks(4627) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2683), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2688), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 10, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2931), new DateTime(2024, 10, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 8, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2946), new DateTime(2024, 8, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 12, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2952), new DateTime(2024, 12, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2958), new DateTime(2024, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2964), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2969), new DateTime(2024, 11, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 9, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2974), new DateTime(2024, 9, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2980), new DateTime(2025, 1, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 3, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2985), new DateTime(2025, 3, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 7, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2990), new DateTime(2024, 7, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3085), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3084), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3078), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3086), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 4, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3184), new DateTime(2025, 4, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3183), new DateTime(2025, 4, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3181), new DateTime(2025, 4, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3185), new DateTime(2025, 4, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3188), new DateTime(2025, 3, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3192), new DateTime(2025, 3, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3191), new DateTime(2025, 3, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3192), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3195), new DateTime(2025, 5, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3198), new DateTime(2025, 5, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3197), new DateTime(2025, 5, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3198), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "DonationType", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3200), new DateTime(2025, 1, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3203), new DateTime(2025, 1, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3202), 0, new DateTime(2025, 1, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3204), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "DonationType", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3206), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3208), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3208), 0, new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3209), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "DonationType", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3211), new DateTime(2025, 3, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3214), new DateTime(2025, 3, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3213), 0, new DateTime(2025, 3, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3215), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3217), new DateTime(2024, 12, 8, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3220), new DateTime(2024, 12, 8, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3219), new DateTime(2024, 12, 8, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3220), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3222), new DateTime(2025, 4, 12, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3225), new DateTime(2025, 4, 12, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3224), new DateTime(2025, 4, 12, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3226), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3228), new DateTime(2025, 5, 12, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3231), new DateTime(2025, 5, 12, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3230), new DateTime(2025, 5, 12, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3231), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3233), new DateTime(2024, 12, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3236), new DateTime(2024, 12, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3235), new DateTime(2024, 12, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3237), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3239), new DateTime(2025, 3, 18, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3242), new DateTime(2025, 3, 18, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3241), new DateTime(2025, 3, 18, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3242), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3244), new DateTime(2025, 5, 7, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3247), new DateTime(2025, 5, 7, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3246), new DateTime(2025, 5, 7, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3248), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3250), new DateTime(2024, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3253), new DateTime(2024, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3252), new DateTime(2024, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3253), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3255), new DateTime(2025, 6, 1, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3258), new DateTime(2025, 6, 1, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3257), new DateTime(2025, 6, 1, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3259), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3260), new DateTime(2025, 4, 7, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3263), new DateTime(2025, 4, 7, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3262), new DateTime(2025, 4, 7, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3264), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3266), new DateTime(2025, 6, 11, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3269), new DateTime(2025, 6, 11, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3268), new DateTime(2025, 6, 11, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3270), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3272), new DateTime(2024, 11, 18, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3275), new DateTime(2024, 11, 18, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3274), new DateTime(2024, 11, 18, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3275), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2873), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2877), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2880), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(2881) });
        }
    }
}
