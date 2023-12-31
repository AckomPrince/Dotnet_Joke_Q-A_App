﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcJoke.Data;

#nullable disable

namespace JokeGenius.Migrations
{
    [DbContext(typeof(MvcJokeContext))]
    [Migration("20230913080344_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("JokeGenius.Models.Joke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("JokeAnswer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("JokeQuestion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Joke");
                });
#pragma warning restore 612, 618
        }
    }
}
