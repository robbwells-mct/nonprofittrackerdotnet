using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonprofitTracker.Migrations
{
    /// <inheritdoc />
    public partial class FixDonationSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3085), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3084), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3078), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3086), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2025, 4, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3184), new DateTime(2025, 4, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3183), new DateTime(2025, 4, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3181), new DateTime(2025, 4, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3185), new DateTime(2025, 4, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3188), new DateTime(2025, 3, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3192), new DateTime(2025, 3, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3191), new DateTime(2025, 3, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3192), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3195), new DateTime(2025, 5, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3198), new DateTime(2025, 5, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3197), new DateTime(2025, 5, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3198), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3200), new DateTime(2025, 1, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3203), new DateTime(2025, 1, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3202), new DateTime(2025, 1, 27, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3204), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3206), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3208), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3208), new DateTime(2025, 2, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3209), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3211), new DateTime(2025, 3, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3214), new DateTime(2025, 3, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3213), new DateTime(2025, 3, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3215), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3217), new DateTime(2024, 12, 8, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3220), new DateTime(2024, 12, 8, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3219), new DateTime(2024, 12, 8, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3220), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3222), new DateTime(2025, 4, 12, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3225), new DateTime(2025, 4, 12, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3224), new DateTime(2025, 4, 12, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3226), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3228), new DateTime(2025, 5, 12, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3231), new DateTime(2025, 5, 12, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3230), new DateTime(2025, 5, 12, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3231), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3233), new DateTime(2024, 12, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3236), new DateTime(2024, 12, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3235), new DateTime(2024, 12, 28, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3237), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3239), new DateTime(2025, 3, 18, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3242), new DateTime(2025, 3, 18, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3241), new DateTime(2025, 3, 18, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3242), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3240) });

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
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3250), new DateTime(2024, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3253), new DateTime(2024, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3252), new DateTime(2024, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3253), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3255), new DateTime(2025, 6, 1, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3258), new DateTime(2025, 6, 1, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3257), new DateTime(2025, 6, 1, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3259), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3260), new DateTime(2025, 4, 7, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3263), new DateTime(2025, 4, 7, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3262), new DateTime(2025, 4, 7, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3264), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3261) });

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
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3272), new DateTime(2024, 11, 18, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3275), new DateTime(2024, 11, 18, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3274), new DateTime(2024, 11, 18, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3275), new DateTime(2025, 6, 26, 19, 33, 19, 232, DateTimeKind.Utc).AddTicks(3272) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7263), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7267), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 10, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7501), new DateTime(2024, 10, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 8, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7516), new DateTime(2024, 8, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 12, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7522), new DateTime(2024, 12, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7527), new DateTime(2024, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 2, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7533), new DateTime(2025, 2, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 11, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7538), new DateTime(2024, 11, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 9, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7544), new DateTime(2024, 9, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 1, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7548), new DateTime(2025, 1, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 3, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7553), new DateTime(2025, 3, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Constituents",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2024, 7, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7608), new DateTime(2024, 7, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7687), new DateTime(2025, 2, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7700), new DateTime(2025, 2, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7693), new DateTime(2025, 2, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7701), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AcknowledgmentStatus", "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { 0, new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7704), new DateTime(2025, 4, 27, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7707), new DateTime(2025, 4, 27, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7706), new DateTime(2025, 4, 27, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7707), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7709), new DateTime(2025, 3, 28, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7712), new DateTime(2025, 3, 28, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7711), new DateTime(2025, 3, 28, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7714), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7716), new DateTime(2025, 5, 27, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7718), new DateTime(2025, 5, 27, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7717), new DateTime(2025, 5, 27, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7719), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7721), new DateTime(2025, 1, 27, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7724), new DateTime(2025, 1, 27, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7723), new DateTime(2025, 1, 27, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7725), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7727), new DateTime(2025, 2, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7730), new DateTime(2025, 2, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7729), new DateTime(2025, 2, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7735), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7737), new DateTime(2025, 3, 28, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7740), new DateTime(2025, 3, 28, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7739), new DateTime(2025, 3, 28, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7740), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7743), new DateTime(2024, 12, 8, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7746), new DateTime(2024, 12, 8, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7745), new DateTime(2024, 12, 8, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7747), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7748), new DateTime(2025, 4, 12, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7752), new DateTime(2025, 4, 12, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7751), new DateTime(2025, 4, 12, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7752), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7754), new DateTime(2025, 5, 12, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7757), new DateTime(2025, 5, 12, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7756), new DateTime(2025, 5, 12, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7758), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7760), new DateTime(2024, 12, 28, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7763), new DateTime(2024, 12, 28, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7762), new DateTime(2024, 12, 28, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7764), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7765), new DateTime(2025, 3, 18, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7768), new DateTime(2025, 3, 18, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7767), new DateTime(2025, 3, 18, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7769), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7771), new DateTime(2025, 5, 7, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7774), new DateTime(2025, 5, 7, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7773), new DateTime(2025, 5, 7, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7775), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7777), new DateTime(2024, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7779), new DateTime(2024, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7779), new DateTime(2024, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7780), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7782), new DateTime(2025, 6, 1, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7786), new DateTime(2025, 6, 1, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7784), new DateTime(2025, 6, 1, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7787), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7788), new DateTime(2025, 4, 7, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7792), new DateTime(2025, 4, 7, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7791), new DateTime(2025, 4, 7, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7793), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7795), new DateTime(2025, 6, 11, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7798), new DateTime(2025, 6, 11, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7797), new DateTime(2025, 6, 11, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7798), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "DateCreated", "DonationDate", "LastUpdated", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7800), new DateTime(2024, 11, 18, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7804), new DateTime(2024, 11, 18, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7803), new DateTime(2024, 11, 18, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7805), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7449), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7453), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "LastUpdated" },
                values: new object[] { new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7456), new DateTime(2025, 6, 26, 19, 0, 48, 68, DateTimeKind.Utc).AddTicks(7457) });
        }
    }
}
