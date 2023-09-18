﻿// <auto-generated />
using System;
using Infrastructure.Data.Postgres.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    [DbContext(typeof(PostgresContext))]
    [Migration("20230915074450_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Adress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DistrictId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DistrictId");

                    b.ToTable("Adress");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Advert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AdressID")
                        .HasColumnType("integer");

                    b.Property<string>("AdvertText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("SportID")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AdressID");

                    b.HasIndex("SportID");

                    b.HasIndex("UserID");

                    b.ToTable("Advert");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Cities", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CityId"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EventID")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EventID");

                    b.HasIndex("UserID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Districts", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DistrictId"));

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DistrictId");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Events", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AdressID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("SportID")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AdressID");

                    b.HasIndex("SportID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AdvertID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("OfferText")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AdvertID");

                    b.HasIndex("UserID");

                    b.ToTable("Offer");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Point", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EventID")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EventID");

                    b.HasIndex("UserID");

                    b.ToTable("Point");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Sports", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("SportImage")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("SportName")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Sports");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.UserEvents", b =>
                {
                    b.Property<int>("EventID")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("EventID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("UserEvents");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.UserToken", b =>
                {
                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Token");

                    b.HasIndex("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Adress", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Cities", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Districts", "District")
                        .WithMany("Addresses")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("District");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Advert", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Adress", "Adress")
                        .WithMany("Adverts")
                        .HasForeignKey("AdressID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Sports", "Sport")
                        .WithMany("Adverts")
                        .HasForeignKey("SportID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithMany("Adverts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adress");

                    b.Navigation("Sport");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Comment", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Events", "Events")
                        .WithMany("Comments")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Events");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Districts", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Cities", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Events", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Adress", "Adress")
                        .WithMany("Events")
                        .HasForeignKey("AdressID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Sports", "Sports")
                        .WithMany("Events")
                        .HasForeignKey("SportID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Adress");

                    b.Navigation("Sports");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Offer", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Advert", "Advert")
                        .WithMany("Offers")
                        .HasForeignKey("AdvertID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithMany("Offers")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Point", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Events", "Events")
                        .WithMany("Points")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithMany("Points")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Events");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.UserEvents", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Events", "Event")
                        .WithMany()
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.UserToken", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Adress", b =>
                {
                    b.Navigation("Adverts");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Advert", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Cities", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Districts");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Districts", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Events", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Points");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Sports", b =>
                {
                    b.Navigation("Adverts");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.Navigation("Adverts");

                    b.Navigation("Comments");

                    b.Navigation("Offers");

                    b.Navigation("Points");
                });
#pragma warning restore 612, 618
        }
    }
}
