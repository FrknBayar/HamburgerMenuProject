﻿// <auto-generated />
using System;
using HamburgerMenuProject.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HamburgerMenuProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230503071859_deneme")]
    partial class deneme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Dessert", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("MenuID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Piece")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.HasIndex("OrderID");

                    b.ToTable("Desserts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8453),
                            IsActive = true,
                            Name = "Souffle",
                            Photo = "Souffle.png",
                            Piece = 1,
                            Price = 14m
                        },
                        new
                        {
                            ID = 2,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8454),
                            IsActive = true,
                            Name = "Chocolate Cookie",
                            Photo = "ChocolateCookie.png",
                            Piece = 1,
                            Price = 6m
                        },
                        new
                        {
                            ID = 3,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8455),
                            IsActive = true,
                            Name = "İce-Cream",
                            Photo = "İceCream.png",
                            Piece = 1,
                            Price = 5m
                        },
                        new
                        {
                            ID = 4,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8456),
                            IsActive = true,
                            Name = "Künefe",
                            Photo = "Künefe.png",
                            Piece = 1,
                            Price = 15m
                        });
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Drink", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("MenuID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Piece")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.HasIndex("OrderID");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8406),
                            IsActive = true,
                            Name = "Fuse Tea",
                            Photo = "FuseTea.png",
                            Piece = 1,
                            Price = 4m,
                            Size = 0
                        },
                        new
                        {
                            ID = 2,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8408),
                            IsActive = true,
                            Name = "Coca-Cola",
                            Photo = "CocaCola.png",
                            Piece = 1,
                            Price = 5m,
                            Size = 0
                        },
                        new
                        {
                            ID = 3,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8409),
                            IsActive = true,
                            Name = "Coca-Cola Zero",
                            Photo = "CocaColaZero.png",
                            Piece = 1,
                            Price = 5m,
                            Size = 0
                        },
                        new
                        {
                            ID = 4,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8410),
                            IsActive = true,
                            Name = "Fanta",
                            Photo = "Fanta.png",
                            Piece = 1,
                            Price = 5m,
                            Size = 0
                        },
                        new
                        {
                            ID = 5,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8411),
                            IsActive = true,
                            Name = "Sprite",
                            Photo = "Sprite.png",
                            Piece = 1,
                            Price = 6m,
                            Size = 0
                        },
                        new
                        {
                            ID = 6,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8412),
                            IsActive = true,
                            Name = "Strawberry Milkshake",
                            Photo = "StrawberryMilkshake.png",
                            Piece = 1,
                            Price = 11m,
                            Size = 0
                        });
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Fries", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("MenuID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Piece")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.HasIndex("OrderID");

                    b.ToTable("Fries");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8441),
                            IsActive = true,
                            Name = "Fried Potatoes",
                            Photo = "Potatoes.png",
                            Piece = 1,
                            Price = 10m,
                            Size = 0
                        },
                        new
                        {
                            ID = 2,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8442),
                            IsActive = true,
                            Name = "Nuggets",
                            Photo = "Nuggets.png",
                            Piece = 1,
                            Price = 8m,
                            Size = 0
                        },
                        new
                        {
                            ID = 3,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8443),
                            IsActive = true,
                            Name = "Onion Rings",
                            Photo = "OnionRings.png",
                            Piece = 1,
                            Price = 9m,
                            Size = 0
                        });
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Hamburger", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("MenuID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Piece")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.HasIndex("OrderID");

                    b.ToTable("Hamburgers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8327),
                            IsActive = true,
                            Name = "Whopper",
                            Photo = "Whopper.png",
                            Piece = 1,
                            Price = 32m
                        },
                        new
                        {
                            ID = 2,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8332),
                            IsActive = true,
                            Name = "Double Whopper",
                            Photo = "DoubleWhopper.png",
                            Piece = 1,
                            Price = 45m
                        },
                        new
                        {
                            ID = 3,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8334),
                            IsActive = true,
                            Name = "Texas Smokehouse",
                            Photo = "TexasSmokeHouse.png",
                            Piece = 1,
                            Price = 37m
                        },
                        new
                        {
                            ID = 4,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8335),
                            IsActive = true,
                            Name = "Cheese Burger",
                            Photo = "Cheeseburger.png",
                            Piece = 1,
                            Price = 29m
                        },
                        new
                        {
                            ID = 5,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8336),
                            IsActive = true,
                            Name = "Chicken Royale",
                            Photo = "ChickenRoyale.png",
                            Piece = 1,
                            Price = 34m
                        },
                        new
                        {
                            ID = 6,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8337),
                            IsActive = true,
                            Name = "Steakhouse",
                            Photo = "SteakHouse.png",
                            Piece = 1,
                            Price = 41m
                        });
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Piece")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8428),
                            IsActive = true,
                            Name = "Whopper Menu",
                            Photo = "WhopperMenu.png",
                            Piece = 1,
                            Price = 50m
                        },
                        new
                        {
                            ID = 2,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8430),
                            IsActive = true,
                            Name = "CheeseBurger Menu",
                            Photo = "CheeseBurgerMenu.png",
                            Piece = 1,
                            Price = 47m
                        },
                        new
                        {
                            ID = 3,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8431),
                            IsActive = true,
                            Name = "Steakhouse Burger Menu",
                            Photo = "SteakHouseMenu.png",
                            Piece = 1,
                            Price = 62m
                        });
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Piece")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Sauce", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("MenuID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Piece")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.HasIndex("OrderID");

                    b.ToTable("Sauces");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8463),
                            IsActive = true,
                            Name = "Mayonnaise",
                            Photo = "Mayonnaise.png",
                            Piece = 1,
                            Price = 1m
                        },
                        new
                        {
                            ID = 2,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8465),
                            IsActive = true,
                            Name = "Ketchup",
                            Photo = "Ketchup.png",
                            Piece = 1,
                            Price = 1m
                        },
                        new
                        {
                            ID = 3,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8466),
                            IsActive = true,
                            Name = "Ranch Sauce",
                            Photo = "RanchSauce.png",
                            Piece = 1,
                            Price = 2m
                        },
                        new
                        {
                            ID = 4,
                            CreatedTime = new DateTime(2023, 5, 3, 10, 18, 58, 614, DateTimeKind.Local).AddTicks(8467),
                            IsActive = true,
                            Name = "Mustard Sauce",
                            Photo = "MustardSauce.png",
                            Piece = 1,
                            Price = 2m
                        });
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.User.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("WhoAdded")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Dessert", b =>
                {
                    b.HasOne("HamburgerMenuProject.Models.Entities.Menu", null)
                        .WithMany("Desserts")
                        .HasForeignKey("MenuID");

                    b.HasOne("HamburgerMenuProject.Models.Entities.Order", null)
                        .WithMany("Desserts")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Drink", b =>
                {
                    b.HasOne("HamburgerMenuProject.Models.Entities.Menu", null)
                        .WithMany("Drinks")
                        .HasForeignKey("MenuID");

                    b.HasOne("HamburgerMenuProject.Models.Entities.Order", null)
                        .WithMany("Drinks")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Fries", b =>
                {
                    b.HasOne("HamburgerMenuProject.Models.Entities.Menu", null)
                        .WithMany("Fries")
                        .HasForeignKey("MenuID");

                    b.HasOne("HamburgerMenuProject.Models.Entities.Order", null)
                        .WithMany("Fries")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Hamburger", b =>
                {
                    b.HasOne("HamburgerMenuProject.Models.Entities.Menu", null)
                        .WithMany("Hamburgers")
                        .HasForeignKey("MenuID");

                    b.HasOne("HamburgerMenuProject.Models.Entities.Order", null)
                        .WithMany("Hamburgers")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Menu", b =>
                {
                    b.HasOne("HamburgerMenuProject.Models.Entities.Order", null)
                        .WithMany("Menus")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Order", b =>
                {
                    b.HasOne("HamburgerMenuProject.Models.User.AppUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Sauce", b =>
                {
                    b.HasOne("HamburgerMenuProject.Models.Entities.Menu", null)
                        .WithMany("Sauces")
                        .HasForeignKey("MenuID");

                    b.HasOne("HamburgerMenuProject.Models.Entities.Order", null)
                        .WithMany("Sauces")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HamburgerMenuProject.Models.User.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HamburgerMenuProject.Models.User.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HamburgerMenuProject.Models.User.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HamburgerMenuProject.Models.User.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Menu", b =>
                {
                    b.Navigation("Desserts");

                    b.Navigation("Drinks");

                    b.Navigation("Fries");

                    b.Navigation("Hamburgers");

                    b.Navigation("Sauces");
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.Entities.Order", b =>
                {
                    b.Navigation("Desserts");

                    b.Navigation("Drinks");

                    b.Navigation("Fries");

                    b.Navigation("Hamburgers");

                    b.Navigation("Menus");

                    b.Navigation("Sauces");
                });

            modelBuilder.Entity("HamburgerMenuProject.Models.User.AppUser", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
