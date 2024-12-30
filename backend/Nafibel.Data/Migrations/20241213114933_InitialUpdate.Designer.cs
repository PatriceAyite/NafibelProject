﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nafibel.Data.Repositories;
using NetTopologySuite.Geometries;

#nullable disable

namespace Nafibel.Data.Migrations
{
    [DbContext(typeof(NafibelDbContext))]
    [Migration("20241213114933_InitialUpdate")]
    partial class InitialUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Nafibel.Data.Model.Appointment", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<DateOnly>("AppointmentDate")
                        .HasColumnType("date");

                    b.Property<byte[]>("ClientId")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<TimeOnly>("From")
                        .HasColumnType("time");

                    b.Property<byte[]>("HairStyleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("HairdresserId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Point>("Location")
                        .HasColumnType("geography");

                    b.Property<int>("LocationType")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("To")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("HairStyleId");

                    b.HasIndex("HairdresserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Nafibel.Data.Model.Client", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<int>("AgeRange")
                        .HasColumnType("int");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Point>("Location")
                        .HasColumnType("geography");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Nafibel.Data.Model.HairStyle", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<int?>("AverageTime")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("HairType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("MaintenanceLevel")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("HairStyles");
                });

            modelBuilder.Entity("Nafibel.Data.Model.HairStyleImage", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("AltText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("HairStyleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte>("Order")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("HairStyleId");

                    b.ToTable("HairStyleImages");
                });

            modelBuilder.Entity("Nafibel.Data.Model.HairStyleNameLocale", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<byte[]>("HairstyleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Locale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("HairstyleId");

                    b.ToTable("HairStyleNameLocales");
                });

            modelBuilder.Entity("Nafibel.Data.Model.HairStylePopularity", b =>
                {
                    b.Property<byte[]>("HairStyleId")
                        .HasColumnType("varbinary(16)");

                    b.Property<short>("Popularity")
                        .HasColumnType("smallint");

                    b.HasKey("HairStyleId");

                    b.ToTable("HairStylePopularities");
                });

            modelBuilder.Entity("Nafibel.Data.Model.HairStylePrice", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("HairStyleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HairStyleId");

                    b.ToTable("HairStylePrices");
                });

            modelBuilder.Entity("Nafibel.Data.Model.Haircut", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("AppointmentId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("EndHaircutDatetime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("HairStyleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime?>("StartHaircutDatetime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HairStyleId");

                    b.ToTable("Haircut");
                });

            modelBuilder.Entity("Nafibel.Data.Model.Hairdresser", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Point>("Location")
                        .HasColumnType("geography");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProfileImage")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("ProfileText")
                        .HasMaxLength(4000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hairdressers");
                });

            modelBuilder.Entity("Nafibel.Data.Model.HairdresserHairStyle", b =>
                {
                    b.Property<byte[]>("HairdresserId")
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("HairStyleId")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("HairdresserId", "HairStyleId");

                    b.HasIndex("HairStyleId");

                    b.ToTable("HairdresserHairStyles");
                });

            modelBuilder.Entity("Nafibel.Data.Model.Payment", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<byte[]>("AppointmentId")
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("ClientId")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalPayload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("HaircutId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("HaircutId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Nafibel.Data.Model.Rating", b =>
                {
                    b.Property<byte[]>("Id")
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("AppointmentId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Comments")
                        .HasMaxLength(4000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<byte[]>("HairStyleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("HairdresserId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<short>("Rate")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Nafibel.Data.Model.Appointment", b =>
                {
                    b.HasOne("Nafibel.Data.Model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("Nafibel.Data.Model.HairStyle", "HairStyle")
                        .WithMany()
                        .HasForeignKey("HairStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nafibel.Data.Model.Hairdresser", "Hairdresser")
                        .WithMany()
                        .HasForeignKey("HairdresserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("HairStyle");

                    b.Navigation("Hairdresser");
                });

            modelBuilder.Entity("Nafibel.Data.Model.HairStyleImage", b =>
                {
                    b.HasOne("Nafibel.Data.Model.HairStyle", "HairStyle")
                        .WithMany("Images")
                        .HasForeignKey("HairStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HairStyle");
                });

            modelBuilder.Entity("Nafibel.Data.Model.HairStyleNameLocale", b =>
                {
                    b.HasOne("Nafibel.Data.Model.HairStyle", "HairStyle")
                        .WithMany("Locales")
                        .HasForeignKey("HairstyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HairStyle");
                });

            modelBuilder.Entity("Nafibel.Data.Model.HairStylePrice", b =>
                {
                    b.HasOne("Nafibel.Data.Model.HairStyle", "HairStyle")
                        .WithMany("HairStylePrices")
                        .HasForeignKey("HairStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HairStyle");
                });

            modelBuilder.Entity("Nafibel.Data.Model.Haircut", b =>
                {
                    b.HasOne("Nafibel.Data.Model.HairStyle", "HairStyle")
                        .WithMany()
                        .HasForeignKey("HairStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HairStyle");
                });

            modelBuilder.Entity("Nafibel.Data.Model.HairdresserHairStyle", b =>
                {
                    b.HasOne("Nafibel.Data.Model.HairStyle", "HairStyle")
                        .WithMany("Hairdressers")
                        .HasForeignKey("HairStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nafibel.Data.Model.Hairdresser", "Hairdresser")
                        .WithMany("HairStyles")
                        .HasForeignKey("HairdresserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HairStyle");

                    b.Navigation("Hairdresser");
                });

            modelBuilder.Entity("Nafibel.Data.Model.Payment", b =>
                {
                    b.HasOne("Nafibel.Data.Model.Appointment", null)
                        .WithMany("Payments")
                        .HasForeignKey("AppointmentId");

                    b.HasOne("Nafibel.Data.Model.Haircut", "Haircut")
                        .WithMany()
                        .HasForeignKey("HaircutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Haircut");
                });

            modelBuilder.Entity("Nafibel.Data.Model.Appointment", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Nafibel.Data.Model.HairStyle", b =>
                {
                    b.Navigation("HairStylePrices");

                    b.Navigation("Hairdressers");

                    b.Navigation("Images");

                    b.Navigation("Locales");
                });

            modelBuilder.Entity("Nafibel.Data.Model.Hairdresser", b =>
                {
                    b.Navigation("HairStyles");
                });
#pragma warning restore 612, 618
        }
    }
}
