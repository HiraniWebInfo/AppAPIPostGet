﻿// <auto-generated />
using System;
using App9M.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App9M.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241124074110_tblHeaders")]
    partial class tblHeaders
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("App9M.Entity.Models.tblHeaders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HeaderKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HeaderValue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tblHeaders");
                });

            modelBuilder.Entity("App9M.Entity.Models.tblParameters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FinalValue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PathValue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tblParameters");
                });

            modelBuilder.Entity("App9M.Entity.Models.tblSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tblSettings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 11, 24, 13, 11, 10, 566, DateTimeKind.Local).AddTicks(5222),
                            Description = "",
                            Name = "BaseUrl"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 11, 24, 13, 11, 10, 566, DateTimeKind.Local).AddTicks(5232),
                            Description = "",
                            Name = "LoginReqType"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 11, 24, 13, 11, 10, 566, DateTimeKind.Local).AddTicks(5233),
                            Description = "",
                            Name = "LoginUrl"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 11, 24, 13, 11, 10, 566, DateTimeKind.Local).AddTicks(5235),
                            Description = "",
                            Name = "LoginReqJson"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 11, 24, 13, 11, 10, 566, DateTimeKind.Local).AddTicks(5236),
                            Description = "",
                            Name = "LoginRespJson"
                        });
                });

            modelBuilder.Entity("App9M.Entity.Models.tblUrlList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReqJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReqType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tblUrlList");
                });
#pragma warning restore 612, 618
        }
    }
}
