﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SP.Api.Data;

#nullable disable

namespace SP.Api.Migrations
{
    [DbContext(typeof(SPContext))]
    [Migration("20231127193023_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "00000000-0000-0000-0000-000000000001",
                            ConcurrencyStamp = "151fde09-3c03-42f3-aa05-7a41dae10ff5",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "00000000-0000-0000-0000-000000000001",
                            RoleId = "00000000-0000-0000-0000-000000000001"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SP.Api.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("NumberOfCertificates")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("ReceiveWeeklyStats")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "00000000-0000-0000-0000-000000000001",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58",
                            Email = "admin@programmingintegration.be",
                            EmailConfirmed = true,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@PROGRAMMINGINTEGRATION.BE",
                            NormalizedUserName = "ADMIN@PROGRAMMINGINTEGRATION.BE",
                            NumberOfCertificates = 3,
                            PasswordHash = "AQAAAAEAACcQAAAAEGA5y+aJt7MxIWBEo4Te7nQiYCI+MF8Yj88d6YsA9NlOBj8pUIz4cuArQXRfnVjECQ==",
                            PhoneNumberConfirmed = false,
                            ReceiveWeeklyStats = true,
                            SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA",
                            TwoFactorEnabled = false,
                            UserName = "admin@programmingintegration.be"
                        });
                });

            modelBuilder.Entity("SP.Api.Entities.StudyProgramme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudyProgrammes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Wil je kantoren en bedrijven later een staaltje accounting magic laten zien? Heb je oog voor detail, oor voor klantvragen en stalen zenuwen als het op deadlines aankomt? Ben je nauwkeurig en kijk je graag naar de cijfers na de komma?",
                            Image = "https://www.howest.be/fs/styles/searchresult/public/images/AAD%20voorbeeld%20banner.jpg?h=fb98929e&itok=Mafsm4py",
                            Location = "Campus Brugge Station",
                            Title = "Accounting Administration",
                            Type = "Graduaat",
                            WebsiteUrl = "https://www.howest.be/nl/opleidingen/graduaat/accounting-administration"
                        },
                        new
                        {
                            Id = 2,
                            Description = "De wereld van de moleculaire biologie ontwikkelt zich razendsnel, in het bijzonder door het toenemende belang van Next Generation Sequencing en big data, naast de traditionele onderzoeksmethoden.",
                            Image = "https://www.howest.be/fs/styles/searchresult/public/images/52169372271_9143a62551_k.jpg?h=136ae0e5&itok=K8UXwpfl",
                            Location = "Kortrijk",
                            Title = "Advanced Bachelor of Bioinformatics",
                            Type = "Bachelor na bachelor",
                            WebsiteUrl = "https://www.howest.be/nl/opleidingen/bachelor-na-bachelor/advanced-bachelor-of-bioinformatics"
                        },
                        new
                        {
                            Id = 3,
                            Description = "De wereld van de moleculaire biologie ontwikkelt zich razendsnel, in het bijzonder door het toenemende belang van Next Generation Sequencing en big data, naast de traditionele onderzoeksmethoden.",
                            Image = "https://www.howest.be/fs/styles/searchresult/public/images/52169372271_9143a62551_k.jpg?h=136ae0e5&itok=K8UXwpfl",
                            Location = "Campus Brugge Station",
                            Title = "Advanced Bachelor of Bioinformatics at home",
                            Type = "Bachelor na bachelor",
                            WebsiteUrl = "https://www.howest.be/nl/opleidingen/bachelor-na-bachelor/advanced-bachelor-of-bioinformatics-at-home"
                        },
                        new
                        {
                            Id = 4,
                            Description = "De bachelor Bedrijfsmanagement is de perfecte opleiding om later in de bedrijfswereld aan de slag te gaan. Je wordt meteen ondergedompeld in het werkveld met echte projecten, bedrijfsbezoeken en studiereizen in binnen- en buitenland.",
                            Image = "https://www.howest.be/fs/styles/searchresult/public/images/BM_Bedrijfsmanagement_banner.jpg?h=a6ad8000&itok=nvVdoA6J",
                            Location = "Kortrijk",
                            Title = "Bedrijfsmanagement",
                            Type = "Bachelor",
                            WebsiteUrl = "https://www.howest.be/nl/opleidingen/bachelor/bedrijfsmanagement"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Biomedische Laboratoriumtechnologie is een brede, polyvalente en praktijkgerichte opleiding die uniek is in West-Vlaanderen. Het programma stoomt je als wetenschappelijk medewerker helemaal klaar voor de biomedische uitdagingen van de 21ste eeuw.",
                            Image = "https://www.howest.be/fs/styles/searchresult/public/images/20211125_Howest_foto_BLT_Brochure-05936.jpg?h=3a3df0c5&itok=7IDTDqwC",
                            Location = "Campus Brugge Station",
                            Title = "Biomedische",
                            Type = "Bachelor",
                            WebsiteUrl = "https://www.howest.be/nl/opleidingen/bachelor/biomedische-laboratoriumtechnologie"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Droom je van het tekenen van bouwplannen? Ben je geïnteresseerd in de technische kant van de bouwsector? Wil je je materialenkennis uitbreiden en je ruimtelijke en bouwkundige inzicht versterken? Dan is de graduaatsopleiding Bouwkundig Tekenen in Brugge of Kortrijk iets voor jou.",
                            Image = "https://www.howest.be/fs/styles/searchresult/public/images/51973282711_7932026739_k.jpg?h=1760b068&itok=pt6D_mZm",
                            Location = "Kortrijk",
                            Title = "Bouwkundig Tekenen",
                            Type = "Graduaat",
                            WebsiteUrl = "https://www.howest.be/nl/opleidingen/graduaat/bouwkundig-tekenen"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SP.Api.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SP.Api.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SP.Api.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SP.Api.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}