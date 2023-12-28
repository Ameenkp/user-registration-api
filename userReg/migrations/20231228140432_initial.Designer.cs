﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using userReg.data;

#nullable disable

namespace userReg.migrations
{
    [DbContext(typeof(ApplicantDbContext))]
    [Migration("20231228140432_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("userReg.Models.Applicant", b =>
                {
                    b.Property<int>("AppId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("APP_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppId"));

                    b.Property<int>("AppAge")
                        .HasColumnType("int")
                        .HasColumnName("APP_AGE");

                    b.Property<string>("AppCurrentEmployer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("APP_CURRENTEMPLOYER");

                    b.Property<DateTime>("AppDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("APP_DATE");

                    b.Property<DateTime>("AppDob")
                        .HasColumnType("datetime2")
                        .HasColumnName("APP_DOB");

                    b.Property<string>("AppEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("APP_EMAIL");

                    b.Property<string>("AppGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("APP_GENDER");

                    b.Property<string>("AppMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("APP_MOBILE");

                    b.Property<string>("AppName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("APP_NAME");

                    b.Property<string>("AppNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("APP_NO");

                    b.Property<decimal?>("AppNoYears")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("APP_NOYEARS");

                    b.Property<int?>("AppNp")
                        .HasColumnType("int")
                        .HasColumnName("APP_NP");

                    b.Property<string>("AppPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("APP_POSITION");

                    b.Property<string>("AppReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("APP_REASON");

                    b.HasKey("AppId");

                    b.ToTable("APP_REG");
                });
#pragma warning restore 612, 618
        }
    }
}