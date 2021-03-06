﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using POSSolution.Application.Context;

namespace POSSolution.Application.Migrations
{
    [DbContext(typeof(POSContext))]
    [Migration("20200225153008_AddMenuAndItem")]
    partial class AddMenuAndItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("POSSolution.Application.Models.Region", b =>
                {
                    b.Property<Guid>("regionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("shopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("regionId");

                    b.HasIndex("shopId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("POSSolution.Application.Models.Shop", b =>
                {
                    b.Property<Guid>("shopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("shopId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("POSSolution.Application.Models.ShopStatus", b =>
                {
                    b.Property<Guid>("statusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("statusId");

                    b.ToTable("ShopStatuses");
                });

            modelBuilder.Entity("POSSolution.Application.Models.Table", b =>
                {
                    b.Property<int>("tableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("createUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("currentPeople")
                        .HasColumnType("int");

                    b.Property<Guid?>("regionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tableCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tableName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("tableId");

                    b.HasIndex("regionId");

                    b.ToTable("Table");
                });

            modelBuilder.Entity("POSSolution.Application.Models.Region", b =>
                {
                    b.HasOne("POSSolution.Application.Models.Shop", "shop")
                        .WithMany("regions")
                        .HasForeignKey("shopId");
                });

            modelBuilder.Entity("POSSolution.Application.Models.Table", b =>
                {
                    b.HasOne("POSSolution.Application.Models.Region", "region")
                        .WithMany("tables")
                        .HasForeignKey("regionId");
                });
#pragma warning restore 612, 618
        }
    }
}
