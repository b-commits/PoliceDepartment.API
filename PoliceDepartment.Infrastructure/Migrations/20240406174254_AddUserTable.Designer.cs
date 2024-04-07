﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoliceDepartment.Infrastructure.DAL;

#nullable disable

namespace PoliceDepartment.Infrastructure.Migrations
{
    [DbContext(typeof(PoliceDepartmentDbContext))]
    [Migration("20240406174254_AddUserTable")]
    partial class AddUserTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

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

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("Modified")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("PoliceOfficer", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9bf33505-5554-493a-ba92-50206e0d0e05"),
                            BadgeNumber = "#-123-436-534",
                            BirthDate = new DateTime(1995, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Bobson",
                            LastName = "Dugnutt",
                            Modified = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("7d68e63e-32d5-4dc4-ad34-5902e29142a0"),
                            BadgeNumber = "#-123-392-166",
                            BirthDate = new DateTime(1985, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Sleve",
                            LastName = "McDeichel",
                            Modified = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("8bdb23d3-ae1b-4ef2-8c77-27a83a02304a"),
                            BadgeNumber = "#-232-767-666",
                            BirthDate = new DateTime(1965, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Rey",
                            LastName = "McSriff",
                            Modified = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("e51d5552-6751-40e8-ae07-b98fe99f4275"),
                            BadgeNumber = "#-896-921-338",
                            BirthDate = new DateTime(1975, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Glenallen",
                            LastName = "Mixon",
                            Modified = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("7c8625b5-c783-47e8-aa56-929b06142962"),
                            BadgeNumber = "#-766-655-594",
                            BirthDate = new DateTime(1968, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Rawl",
                            LastName = "Chamgerlain",
                            Modified = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("d0b3f4c8-0411-4169-a69a-37883ddda421"),
                            BadgeNumber = "#-778-988-363",
                            BirthDate = new DateTime(1986, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Kevin",
                            LastName = "Nogilny",
                            Modified = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("10344b85-1b85-4117-bd08-e1fa3e874650"),
                            BadgeNumber = "#-569-450-729",
                            BirthDate = new DateTime(1982, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Tony",
                            LastName = "Smherik",
                            Modified = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("8b267d27-9278-4704-b7c0-01f56c407bce"),
                            BadgeNumber = "#-454-443-541",
                            BirthDate = new DateTime(1973, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Willie",
                            LastName = "Dustice",
                            Modified = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("11a3501f-3626-4dcf-acf9-b580d94c955f"),
                            BadgeNumber = "#-405-341-807",
                            BirthDate = new DateTime(1995, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Mario",
                            LastName = "McRwlain",
                            Modified = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("e97de61e-74f5-4ea5-819f-4b4d3defd60a"),
                            BadgeNumber = "#-569-541-836",
                            BirthDate = new DateTime(1956, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Todd",
                            LastName = "Bonzalez",
                            Modified = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("PoliceDepartment.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("Modified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}