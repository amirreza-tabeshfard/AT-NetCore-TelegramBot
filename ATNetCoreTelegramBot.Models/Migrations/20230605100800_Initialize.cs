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
                name: "person");

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
                name: "Culture",
                schema: "base",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageCultureName = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CultureCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Culture", x => x.Id);
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
                name: "AddressType",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressType_Culture_CultureId",
                        column: x => x.CultureId,
                        principalSchema: "base",
                        principalTable: "Culture",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "base",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_Culture_CultureId",
                        column: x => x.CultureId,
                        principalSchema: "base",
                        principalTable: "Culture",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmailType",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailType_Culture_CultureId",
                        column: x => x.CultureId,
                        principalSchema: "base",
                        principalTable: "Culture",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InstantMessageType",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstantMessageType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstantMessageType_Culture_CultureId",
                        column: x => x.CultureId,
                        principalSchema: "base",
                        principalTable: "Culture",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PhoneType",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneType_Culture_CultureId",
                        column: x => x.CultureId,
                        principalSchema: "base",
                        principalTable: "Culture",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SocialType",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialType_Culture_CultureId",
                        column: x => x.CultureId,
                        principalSchema: "base",
                        principalTable: "Culture",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UrlType",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UrlType_Culture_CultureId",
                        column: x => x.CultureId,
                        principalSchema: "base",
                        principalTable: "Culture",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthCertificate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AboutMe = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    Avatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Culture_CultureId",
                        column: x => x.CultureId,
                        principalSchema: "base",
                        principalTable: "Culture",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Person_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "telegram",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Province",
                schema: "base",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Province_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "base",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Province_Culture_CultureId",
                        column: x => x.CultureId,
                        principalSchema: "base",
                        principalTable: "Culture",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Email",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Email_EmailType_EmailTypeId",
                        column: x => x.EmailTypeId,
                        principalSchema: "person",
                        principalTable: "EmailType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Email_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "person",
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gender_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "person",
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InstantMessage",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstantMessageTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstantMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstantMessage_InstantMessageType_InstantMessageTypeId",
                        column: x => x.InstantMessageTypeId,
                        principalSchema: "person",
                        principalTable: "InstantMessageType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InstantMessage_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "person",
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaritalStatus_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "person",
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MilitaryServiceStatus",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryServiceStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MilitaryServiceStatus_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "person",
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phone_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "person",
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Phone_PhoneType_PhoneTypeId",
                        column: x => x.PhoneTypeId,
                        principalSchema: "person",
                        principalTable: "PhoneType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Social",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocialTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Social", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Social_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "person",
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Social_SocialType_SocialTypeId",
                        column: x => x.SocialTypeId,
                        principalSchema: "person",
                        principalTable: "SocialType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Url",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UrlTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Url", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Url_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "person",
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Url_UrlType_UrlTypeId",
                        column: x => x.UrlTypeId,
                        principalSchema: "person",
                        principalTable: "UrlType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "City",
                schema: "base",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Culture_CultureId",
                        column: x => x.CultureId,
                        principalSchema: "base",
                        principalTable: "Culture",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_City_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalSchema: "base",
                        principalTable: "Province",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CultureId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressTypeId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalSchema: "person",
                        principalTable: "AddressType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "base",
                        principalTable: "City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_Culture_CultureId",
                        column: x => x.CultureId,
                        principalSchema: "base",
                        principalTable: "Culture",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "person",
                        principalTable: "Person",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_person.Address.AddressTypeId",
                schema: "person",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_person.Address.CityId",
                schema: "person",
                table: "Address",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_person.Address.CultureId",
                schema: "person",
                table: "Address",
                column: "CultureId");

            migrationBuilder.CreateIndex(
                name: "IX_person.Address.PersonId",
                schema: "person",
                table: "Address",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_person.AddressType.CultureId",
                schema: "person",
                table: "AddressType",
                column: "CultureId");

            migrationBuilder.CreateIndex(
                name: "IX_person.AddressType.Name",
                schema: "person",
                table: "AddressType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_telegram.Channels.Name",
                schema: "telegram",
                table: "Channels",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_base.City.CultureId",
                schema: "base",
                table: "City",
                column: "CultureId");

            migrationBuilder.CreateIndex(
                name: "IX_base.City.ProvinceId_Name",
                schema: "base",
                table: "City",
                columns: new[] { "ProvinceId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_base.Country.CultureId",
                schema: "base",
                table: "Country",
                column: "CultureId");

            migrationBuilder.CreateIndex(
                name: "IX_base.Country.Name",
                schema: "base",
                table: "Country",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_base.Culture.CultureCode",
                schema: "base",
                table: "Culture",
                column: "CultureCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_base.Culture.DisplayName",
                schema: "base",
                table: "Culture",
                column: "DisplayName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_base.Culture.LanguageCultureName",
                schema: "base",
                table: "Culture",
                column: "LanguageCultureName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person.Email.EmailTypeId",
                schema: "person",
                table: "Email",
                column: "EmailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_person.Email.PersonId",
                schema: "person",
                table: "Email",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_person.EmailType.CultureId",
                schema: "person",
                table: "EmailType",
                column: "CultureId");

            migrationBuilder.CreateIndex(
                name: "IX_person.EmailType.Name",
                schema: "person",
                table: "EmailType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person.Gender.Name",
                schema: "person",
                table: "Gender",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person.Gender.PersonId",
                schema: "person",
                table: "Gender",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_telegram.Groups.Name",
                schema: "telegram",
                table: "Groups",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person.InstantMessage.InstantMessageTypeId",
                schema: "person",
                table: "InstantMessage",
                column: "InstantMessageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_person.InstantMessage.PersonId",
                schema: "person",
                table: "InstantMessage",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_person.InstantMessageType.CultureId",
                schema: "person",
                table: "InstantMessageType",
                column: "CultureId");

            migrationBuilder.CreateIndex(
                name: "IX_person.InstantMessageType.Name",
                schema: "person",
                table: "InstantMessageType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person.MaritalStatus.Name",
                schema: "person",
                table: "MaritalStatus",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person.MaritalStatus.PersonId",
                schema: "person",
                table: "MaritalStatus",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person.MilitaryServiceStatus.Name",
                schema: "person",
                table: "MilitaryServiceStatus",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person.MilitaryServiceStatus.PersonId",
                schema: "person",
                table: "MilitaryServiceStatus",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_UserId",
                schema: "person",
                table: "Person",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_person.Person.CultureId_UserId",
                schema: "person",
                table: "Person",
                columns: new[] { "CultureId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person.Phone.PersonId",
                schema: "person",
                table: "Phone",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_person.Phone.PhoneTypeId",
                schema: "person",
                table: "Phone",
                column: "PhoneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_person.PhoneType.CultureId",
                schema: "person",
                table: "PhoneType",
                column: "CultureId");

            migrationBuilder.CreateIndex(
                name: "IX_person.PhoneType.Name",
                schema: "person",
                table: "PhoneType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_base.Province.CountryId_Name",
                schema: "base",
                table: "Province",
                columns: new[] { "CountryId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_base.Province.CultureId",
                schema: "base",
                table: "Province",
                column: "CultureId");

            migrationBuilder.CreateIndex(
                name: "IX_person.Social.PersonId",
                schema: "person",
                table: "Social",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_person.Social.SocialTypeId",
                schema: "person",
                table: "Social",
                column: "SocialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_person.SocialType.CultureId",
                schema: "person",
                table: "SocialType",
                column: "CultureId");

            migrationBuilder.CreateIndex(
                name: "IX_person.SocialType.Name",
                schema: "person",
                table: "SocialType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_person.Url.PersonId",
                schema: "person",
                table: "Url",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_person.Url.UrlTypeId",
                schema: "person",
                table: "Url",
                column: "UrlTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_person.UrlType.CultureId",
                schema: "person",
                table: "UrlType",
                column: "CultureId");

            migrationBuilder.CreateIndex(
                name: "IX_person.UrlType.Name",
                schema: "person",
                table: "UrlType",
                column: "Name",
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
                name: "Address",
                schema: "person");

            migrationBuilder.DropTable(
                name: "Channels",
                schema: "telegram");

            migrationBuilder.DropTable(
                name: "Email",
                schema: "person");

            migrationBuilder.DropTable(
                name: "Gender",
                schema: "person");

            migrationBuilder.DropTable(
                name: "Groups",
                schema: "telegram");

            migrationBuilder.DropTable(
                name: "InstantMessage",
                schema: "person");

            migrationBuilder.DropTable(
                name: "MaritalStatus",
                schema: "person");

            migrationBuilder.DropTable(
                name: "MilitaryServiceStatus",
                schema: "person");

            migrationBuilder.DropTable(
                name: "Phone",
                schema: "person");

            migrationBuilder.DropTable(
                name: "Social",
                schema: "person");

            migrationBuilder.DropTable(
                name: "Url",
                schema: "person");

            migrationBuilder.DropTable(
                name: "AddressType",
                schema: "person");

            migrationBuilder.DropTable(
                name: "City",
                schema: "base");

            migrationBuilder.DropTable(
                name: "EmailType",
                schema: "person");

            migrationBuilder.DropTable(
                name: "InstantMessageType",
                schema: "person");

            migrationBuilder.DropTable(
                name: "PhoneType",
                schema: "person");

            migrationBuilder.DropTable(
                name: "SocialType",
                schema: "person");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "person");

            migrationBuilder.DropTable(
                name: "UrlType",
                schema: "person");

            migrationBuilder.DropTable(
                name: "Province",
                schema: "base");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "telegram");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "base");

            migrationBuilder.DropTable(
                name: "Culture",
                schema: "base");
        }
    }
}
