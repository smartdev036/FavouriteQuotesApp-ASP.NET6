﻿// <auto-generated />
using FavouriteQuotesApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FavouriteQuotesApp.Migrations
{
    [DbContext(typeof(QuotesDbContext))]
    partial class QuotesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FavouriteQuotesApp.Models.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = " Author 1",
                            Description = "Inspiring",
                            Rating = 3,
                            Text = "Quote 1"
                        },
                        new
                        {
                            Id = 2,
                            Author = " Author 2",
                            Description = "Motivational",
                            Rating = 4,
                            Text = "Quote 2"
                        },
                        new
                        {
                            Id = 3,
                            Author = " Author 3",
                            Description = "Thought-provoking",
                            Rating = 5,
                            Text = "Quote 3"
                        },
                        new
                        {
                            Id = 4,
                            Author = " Author 1",
                            Description = "Inspiring",
                            Rating = 3,
                            Text = "Quote 4"
                        },
                        new
                        {
                            Id = 5,
                            Author = " Author 2",
                            Description = "Motivational",
                            Rating = 4,
                            Text = "Quote 5"
                        },
                        new
                        {
                            Id = 6,
                            Author = " Author 3",
                            Description = "Thought-provoking",
                            Rating = 5,
                            Text = "Quote 6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}