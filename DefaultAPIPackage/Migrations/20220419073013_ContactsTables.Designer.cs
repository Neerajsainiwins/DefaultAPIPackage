// <auto-generated />
using System;
using DefaultAPIPackage.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DefaultAPIPackage.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220419073013_ContactsTables")]
    partial class ContactsTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DefaultAPIPackage.API.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Direction")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("DefaultAPIPackage.API.Models.TextResourceCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TextResourceCategoryName")
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("TextResourceCategories");
                });

            modelBuilder.Entity("DefaultAPIPackage.API.Models.TextResourceKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("TextResourceCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("TextResourceKeyName")
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("TextResourceKeys");
                });

            modelBuilder.Entity("DefaultAPIPackage.API.Models.TextResourceKeyValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("TextResourceKeyId")
                        .HasColumnType("int");

                    b.Property<string>("TextResourceKeyValueName")
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("TextResourceKeyValues");
                });

            modelBuilder.Entity("DefaultAPIPackage.Models.Entities.CompanyInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("BusinessEmail")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyMainLineNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("CompanyTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("DirectLineNo")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MobileNo1")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MobileNo2")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("CompanyInformations");
                });

            modelBuilder.Entity("DefaultAPIPackage.Models.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.Property<int>("TeamKnowledgeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("DefaultAPIPackage.Models.Entities.PersonalInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("HomePhoneNo")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PersonalEmail")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PersonalNo1")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PersonalNo2")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("PersonalInformations");
                });

            modelBuilder.Entity("DefaultAPIPackage.Models.Entities.Screen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ScreenName")
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("Screens");
                });

            modelBuilder.Entity("DefaultAPIPackage.Models.Entities.TenantScreen", b =>
                {
                    b.Property<int>("ScreenId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.ToTable("TenantScreens", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
