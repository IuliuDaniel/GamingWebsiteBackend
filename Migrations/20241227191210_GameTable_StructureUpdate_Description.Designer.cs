﻿// <auto-generated />
using System;
using GamingWebsiteBE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GamingWebsiteBE.Migrations
{
    [DbContext(typeof(GamingDbContext))]
    [Migration("20241227191210_GameTable_StructureUpdate_Description")]
    partial class GameTable_StructureUpdate_Description
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GamingWebsiteBE.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Developer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("MinimumRequirements")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecommendedRequirements")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrailerUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.HasIndex("GenreId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.GamePlatform", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "PlatformId");

                    b.HasIndex("PlatformId");

                    b.ToTable("GamePlatforms");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.Images", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewsId"), 1L, 1);

                    b.Property<string>("ArticleLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GameId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsId");

                    b.HasIndex("GameId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.Platform", b =>
                {
                    b.Property<int>("PlatformId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlatformId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlatformId");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.Prices", b =>
                {
                    b.Property<int>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PriceId"), 1L, 1);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("PriceId");

                    b.HasIndex("GameId");

                    b.HasIndex("StoreId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoreId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.Game", b =>
                {
                    b.HasOne("GamingWebsiteBE.Models.Genre", "Genre")
                        .WithMany("Games")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.GamePlatform", b =>
                {
                    b.HasOne("GamingWebsiteBE.Models.Game", "Game")
                        .WithMany("GamePlatforms")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamingWebsiteBE.Models.Platform", "Platform")
                        .WithMany("GamePlatforms")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.Images", b =>
                {
                    b.HasOne("GamingWebsiteBE.Models.Game", "Game")
                        .WithMany("Images")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.News", b =>
                {
                    b.HasOne("GamingWebsiteBE.Models.Game", "Game")
                        .WithMany("News")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.Prices", b =>
                {
                    b.HasOne("GamingWebsiteBE.Models.Game", "Game")
                        .WithMany("Prices")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamingWebsiteBE.Models.Store", "Store")
                        .WithMany("Prices")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.Game", b =>
                {
                    b.Navigation("GamePlatforms");

                    b.Navigation("Images");

                    b.Navigation("News");

                    b.Navigation("Prices");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.Genre", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.Platform", b =>
                {
                    b.Navigation("GamePlatforms");
                });

            modelBuilder.Entity("GamingWebsiteBE.Models.Store", b =>
                {
                    b.Navigation("Prices");
                });
#pragma warning restore 612, 618
        }
    }
}
