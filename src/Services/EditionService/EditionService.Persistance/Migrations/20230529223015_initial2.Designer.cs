﻿// <auto-generated />
using System;
using EditionService.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EditionService.Persistance.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20230529223015_initial2")]
    partial class initial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EditionService.Domain.EditionInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedTime");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedTime");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<float>("Price")
                        .HasColumnType("real")
                        .HasColumnName("Price");

                    b.Property<int>("TrialDay")
                        .HasColumnType("int")
                        .HasColumnName("TrialDay");

                    b.HasKey("Id");

                    b.ToTable("Editions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTime(2023, 5, 30, 1, 30, 15, 174, DateTimeKind.Local).AddTicks(1629),
                            IsDeleted = false,
                            Name = "standart",
                            Price = 20f,
                            TrialDay = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTime(2023, 5, 30, 1, 30, 15, 174, DateTimeKind.Local).AddTicks(1645),
                            IsDeleted = false,
                            Name = "admin",
                            Price = 15f,
                            TrialDay = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}