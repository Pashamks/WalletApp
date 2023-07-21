using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreRepository.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    CardBalance = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TransactionType = table.Column<int>(type: "integer", nullable: false),
                    TransactionAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    TransactionName = table.Column<string>(type: "text", nullable: false),
                    TransactionDescription = table.Column<string>(type: "text", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TransactionStatus = table.Column<int>(type: "integer", nullable: false),
                    UserFrom = table.Column<string>(type: "text", nullable: true),
                    IconPath = table.Column<string>(type: "text", nullable: true),
                    UserOwnerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_Transaction_User_UserOwnerId",
                        column: x => x.UserOwnerId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "CardBalance", "FullName" },
                values: new object[,]
                {
                    { 1, 0m, "Pavlo" },
                    { 2, 0m, "JPMorgan" }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "TransactionId", "IconPath", "TransactionAmount", "TransactionDate", "TransactionDescription", "TransactionName", "TransactionStatus", "TransactionType", "UserFrom", "UserOwnerId" },
                values: new object[,]
                {
                    { 1, "https://localhost:7046/img/apple.png", 14.06m, new DateTime(2023, 7, 20, 13, 14, 11, 592, DateTimeKind.Local).AddTicks(5933), "Card Number Used", "Apple", 1, 1, "Diana", 1 },
                    { 2, "https://localhost:7046/img/apple-general.png", 14.06m, new DateTime(2023, 7, 21, 13, 14, 11, 592, DateTimeKind.Local).AddTicks(5996), "Chase Bank Natio...", "Payment", 0, 1, "JPMorgan", 1 },
                    { 3, "https://localhost:7046/img/apple.png", 14.06m, new DateTime(2023, 7, 21, 13, 14, 11, 592, DateTimeKind.Local).AddTicks(5999), "Card Number Used", "Apple", 0, 1, "", 1 },
                    { 4, "https://localhost:7046/img/apple-general.png", 14.06m, new DateTime(2023, 7, 20, 13, 14, 11, 592, DateTimeKind.Local).AddTicks(6003), "Chase Bank Natio...", "Payment", 0, 1, "JPMorgan", 1 },
                    { 5, "https://localhost:7046/img/apple-general.png", 14.06m, new DateTime(2023, 7, 20, 13, 14, 11, 592, DateTimeKind.Local).AddTicks(6006), "Chase Bank Natio...", "Payment", 0, 1, "JPMorgan", 1 },
                    { 6, "https://localhost:7046/img/ikea.png", 14.06m, new DateTime(2022, 7, 21, 13, 14, 11, 592, DateTimeKind.Local).AddTicks(6011), "Round Rock, Tx", "IKEA", 0, 1, "", 1 },
                    { 7, "https://localhost:7046/img/target.png", 14.06m, new DateTime(2023, 7, 20, 13, 14, 11, 592, DateTimeKind.Local).AddTicks(6017), "Cedar Park, TX", "Target", 0, 1, "", 1 },
                    { 8, "https://localhost:7046/img/apple-general.png", 14.06m, new DateTime(2023, 7, 20, 13, 14, 11, 592, DateTimeKind.Local).AddTicks(6022), "Card Number Used", "Apple", 0, 1, "Diana", 1 },
                    { 9, "https://localhost:7046/img/apple-general.png", 14.06m, new DateTime(2023, 7, 20, 13, 14, 11, 592, DateTimeKind.Local).AddTicks(6025), "Card Number Used", "Apple", 0, 1, "Diana", 1 },
                    { 10, "https://localhost:7046/img/apple-general.png", 14.06m, new DateTime(2023, 7, 20, 13, 14, 11, 592, DateTimeKind.Local).AddTicks(6029), "Card Number Used", "Apple", 0, 1, "Diana", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_UserOwnerId",
                table: "Transaction",
                column: "UserOwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
