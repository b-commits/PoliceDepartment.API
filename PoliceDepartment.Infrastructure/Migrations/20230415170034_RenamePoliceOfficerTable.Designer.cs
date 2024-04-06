﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoliceDepartment.Infrastructure.DAL;

#nullable disable

namespace PoliceDepartment.Infrastructure.Migrations
{
    [DbContext(typeof(PoliceDepartmentDbContext))]
    [Migration("20230415170034_RenamePoliceOfficerTable")]
    partial class RenamePoliceOfficerTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PoliceDepartment.Core.Entities.PoliceOfficer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("BadgeNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PoliceOfficer", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5429ebb9-6ef1-44c9-af9f-8f57400218cd"),
                            BadgeNumber = "#-123-436-534",
                            BirthDate = new DateTime(1995, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Bobson",
                            LastName = "Dugnutt"
                        },
                        new
                        {
                            Id = new Guid("36d00338-d72f-41a7-aef3-48746f4c2285"),
                            BadgeNumber = "#-123-392-166",
                            BirthDate = new DateTime(1985, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Sleve",
                            LastName = "McDeichel"
                        },
                        new
                        {
                            Id = new Guid("39dbfbdc-c8b9-466e-a1d8-b9dfb25bff8d"),
                            BadgeNumber = "#-232-767-666",
                            BirthDate = new DateTime(1965, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Rey",
                            LastName = "McSriff"
                        },
                        new
                        {
                            Id = new Guid("1ba457c8-207c-4dfc-88c3-4f7df7526c9b"),
                            BadgeNumber = "#-896-921-338",
                            BirthDate = new DateTime(1975, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Glenallen",
                            LastName = "Mixon"
                        },
                        new
                        {
                            Id = new Guid("acb9d742-1dfc-4f43-bd3d-98c041fb44f0"),
                            BadgeNumber = "#-766-655-594",
                            BirthDate = new DateTime(1968, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Rawl",
                            LastName = "Chamgerlain"
                        },
                        new
                        {
                            Id = new Guid("08ab9053-3ebc-415c-9c4f-9adee66b5795"),
                            BadgeNumber = "#-778-988-363",
                            BirthDate = new DateTime(1986, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kevin",
                            LastName = "Nogilny"
                        },
                        new
                        {
                            Id = new Guid("af9e4a52-4046-4a90-ae1a-d968fb17ec05"),
                            BadgeNumber = "#-569-450-729",
                            BirthDate = new DateTime(1982, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Tony",
                            LastName = "Smherik"
                        },
                        new
                        {
                            Id = new Guid("0e08e9d6-3c91-4d5a-b94d-dbd900c66683"),
                            BadgeNumber = "#-454-443-541",
                            BirthDate = new DateTime(1973, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Willie",
                            LastName = "Dustice"
                        },
                        new
                        {
                            Id = new Guid("bef86b91-7eda-4f38-97c0-6557ff1b396f"),
                            BadgeNumber = "#-405-341-807",
                            BirthDate = new DateTime(1995, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mario",
                            LastName = "McRwlain"
                        },
                        new
                        {
                            Id = new Guid("6795ef05-cc0c-4fb4-891f-b44da081ecfd"),
                            BadgeNumber = "#-569-541-836",
                            BirthDate = new DateTime(1956, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Todd",
                            LastName = "Bonzalez"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}