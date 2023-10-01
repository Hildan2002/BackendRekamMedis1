﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MsCiot_Fix.Db;

#nullable disable

namespace MsCiot_Fix.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231001081631_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MsCiot_Fix.Models.MesinModel", b =>
                {
                    b.Property<int>("IdMesin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMesin"));

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("NamaMesin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMesin");

                    b.HasIndex("IdUser");

                    b.ToTable("MesinModel");
                });

            modelBuilder.Entity("MsCiot_Fix.Models.UserModel", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<int>("BloodPressure")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fat")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Temperature")
                        .HasColumnType("int");

                    b.Property<int>("Temprature")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("IdUser");

                    b.ToTable("UserModel");
                });

            modelBuilder.Entity("MsCiot_Fix.Models.MesinModel", b =>
                {
                    b.HasOne("MsCiot_Fix.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserModel");
                });
#pragma warning restore 612, 618
        }
    }
}