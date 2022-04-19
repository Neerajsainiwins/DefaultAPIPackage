using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DefaultAPIPackage.Migrations
{
    public partial class ContactsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    CompanyTypeId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CompanyMainLineNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessEmail = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    DirectLineNo = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    MobileNo1 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    MobileNo2 = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    TeamKnowledgeId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    TagsId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.Now),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    PersonalNo1 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PersonalNo2 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    HomePhoneNo = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PersonalEmail = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInformations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyInformations");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "PersonalInformations");
        }
    }
}
