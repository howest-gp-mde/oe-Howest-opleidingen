using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SP.Api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfCertificates = table.Column<int>(type: "int", nullable: false),
                    ReceiveWeeklyStats = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyProgrammes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyProgrammes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", "151fde09-3c03-42f3-aa05-7a41dae10ff5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "NumberOfCertificates", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ReceiveWeeklyStats", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", 0, "c8554266-b401-4519-9aeb-a9283053fc58", "admin@programmingintegration.be", true, "John", "Doe", false, null, "ADMIN@PROGRAMMINGINTEGRATION.BE", "ADMIN@PROGRAMMINGINTEGRATION.BE", 3, "AQAAAAEAACcQAAAAEGA5y+aJt7MxIWBEo4Te7nQiYCI+MF8Yj88d6YsA9NlOBj8pUIz4cuArQXRfnVjECQ==", null, false, true, "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", false, "admin@programmingintegration.be" });

            migrationBuilder.InsertData(
                table: "StudyProgrammes",
                columns: new[] { "Id", "Description", "Image", "Location", "Title", "Type", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, "Wil je kantoren en bedrijven later een staaltje accounting magic laten zien? Heb je oog voor detail, oor voor klantvragen en stalen zenuwen als het op deadlines aankomt? Ben je nauwkeurig en kijk je graag naar de cijfers na de komma?", "https://www.howest.be/fs/styles/searchresult/public/images/AAD%20voorbeeld%20banner.jpg?h=fb98929e&itok=Mafsm4py", "Campus Brugge Station", "Accounting Administration", "Graduaat", "https://www.howest.be/nl/opleidingen/graduaat/accounting-administration" },
                    { 2, "De wereld van de moleculaire biologie ontwikkelt zich razendsnel, in het bijzonder door het toenemende belang van Next Generation Sequencing en big data, naast de traditionele onderzoeksmethoden.", "https://www.howest.be/fs/styles/searchresult/public/images/52169372271_9143a62551_k.jpg?h=136ae0e5&itok=K8UXwpfl", "Kortrijk", "Advanced Bachelor of Bioinformatics", "Bachelor na bachelor", "https://www.howest.be/nl/opleidingen/bachelor-na-bachelor/advanced-bachelor-of-bioinformatics" },
                    { 3, "De wereld van de moleculaire biologie ontwikkelt zich razendsnel, in het bijzonder door het toenemende belang van Next Generation Sequencing en big data, naast de traditionele onderzoeksmethoden.", "https://www.howest.be/fs/styles/searchresult/public/images/52169372271_9143a62551_k.jpg?h=136ae0e5&itok=K8UXwpfl", "Campus Brugge Station", "Advanced Bachelor of Bioinformatics at home", "Bachelor na bachelor", "https://www.howest.be/nl/opleidingen/bachelor-na-bachelor/advanced-bachelor-of-bioinformatics-at-home" },
                    { 4, "De bachelor Bedrijfsmanagement is de perfecte opleiding om later in de bedrijfswereld aan de slag te gaan. Je wordt meteen ondergedompeld in het werkveld met echte projecten, bedrijfsbezoeken en studiereizen in binnen- en buitenland.", "https://www.howest.be/fs/styles/searchresult/public/images/BM_Bedrijfsmanagement_banner.jpg?h=a6ad8000&itok=nvVdoA6J", "Kortrijk", "Bedrijfsmanagement", "Bachelor", "https://www.howest.be/nl/opleidingen/bachelor/bedrijfsmanagement" },
                    { 5, "Biomedische Laboratoriumtechnologie is een brede, polyvalente en praktijkgerichte opleiding die uniek is in West-Vlaanderen. Het programma stoomt je als wetenschappelijk medewerker helemaal klaar voor de biomedische uitdagingen van de 21ste eeuw.", "https://www.howest.be/fs/styles/searchresult/public/images/20211125_Howest_foto_BLT_Brochure-05936.jpg?h=3a3df0c5&itok=7IDTDqwC", "Campus Brugge Station", "Biomedische", "Bachelor", "https://www.howest.be/nl/opleidingen/bachelor/biomedische-laboratoriumtechnologie" },
                    { 6, "Droom je van het tekenen van bouwplannen? Ben je geïnteresseerd in de technische kant van de bouwsector? Wil je je materialenkennis uitbreiden en je ruimtelijke en bouwkundige inzicht versterken? Dan is de graduaatsopleiding Bouwkundig Tekenen in Brugge of Kortrijk iets voor jou.", "https://www.howest.be/fs/styles/searchresult/public/images/51973282711_7932026739_k.jpg?h=1760b068&itok=pt6D_mZm", "Kortrijk", "Bouwkundig Tekenen", "Graduaat", "https://www.howest.be/nl/opleidingen/graduaat/bouwkundig-tekenen" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "StudyProgrammes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
