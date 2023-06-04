using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATNetCoreTelegramBot.Models.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "telegram");

            migrationBuilder.EnsureSchema(
                name: "base");

            migrationBuilder.CreateTable(
                name: "Channels",
                schema: "telegram",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Ordering = table.Column<int>(type: "int", nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "base",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                schema: "telegram",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Ordering = table.Column<int>(type: "int", nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "telegram",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    ChatID = table.Column<long>(type: "bigint", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsBot = table.Column<bool>(type: "bit", nullable: false),
                    IsPremium = table.Column<bool>(type: "bit", nullable: true),
                    LanguageCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AddedToAttachmentMenu = table.Column<bool>(type: "bit", nullable: true),
                    CanJoinGroups = table.Column<bool>(type: "bit", nullable: true),
                    CanReadAllGroupMessages = table.Column<bool>(type: "bit", nullable: true),
                    SupportsInlineQueries = table.Column<bool>(type: "bit", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                schema: "base",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provinces_Countries_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "base",
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "base",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalSchema: "base",
                        principalTable: "Provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_telegram.Channels.Name",
                schema: "telegram",
                table: "Channels",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_base.Cities.ProvinceId_Name",
                schema: "base",
                table: "Cities",
                columns: new[] { "ProvinceId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_base.Countries.Name",
                schema: "base",
                table: "Countries",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_telegram.Groups.Name",
                schema: "telegram",
                table: "Groups",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_base.Provinces.CountryId_Name",
                schema: "base",
                table: "Provinces",
                columns: new[] { "CountryId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_telegram.Users.UserName",
                schema: "telegram",
                table: "Users",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Channels",
                schema: "telegram");

            migrationBuilder.DropTable(
                name: "Cities",
                schema: "base");

            migrationBuilder.DropTable(
                name: "Groups",
                schema: "telegram");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "telegram");

            migrationBuilder.DropTable(
                name: "Provinces",
                schema: "base");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "base");
        }
    }
}
