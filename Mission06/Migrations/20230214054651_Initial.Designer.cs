﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06.Models;

namespace Mission06.Migrations
{
    [DbContext(typeof(MovieApplicationContext))]
    [Migration("20230214054651_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission06.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            Category = "Action",
                            Director = "Joss Whedon",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Avengers",
                            Year = 2018
                        },
                        new
                        {
                            ApplicationId = 2,
                            Category = "Action",
                            Director = "George Lucas",
                            Edited = false,
                            Rating = "PG",
                            Title = "Star Wars",
                            Year = 1977
                        },
                        new
                        {
                            ApplicationId = 3,
                            Category = "Action",
                            Director = "Mel Gibson",
                            Edited = false,
                            Rating = "R",
                            Title = "Braveheart",
                            Year = 1995
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
