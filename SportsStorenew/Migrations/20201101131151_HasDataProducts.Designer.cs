﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsStorenew.Domain.DB;

namespace SportsStorenew.Migrations
{
    [DbContext(typeof(SportsStoreDbContext))]
    [Migration("20201101131151_HasDataProducts")]
    partial class HasDataProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsStorenew.Domain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SportsStorenew.Domain.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 3,
                            Name = "Product 1",
                            Price = 21m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 5,
                            Name = "Product 2",
                            Price = 22m
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 5,
                            Name = "Product 3",
                            Price = 23m
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 4,
                            Name = "Product 4",
                            Price = 24m
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1,
                            Name = "Product 5",
                            Price = 25m
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 5,
                            Name = "Product 6",
                            Price = 26m
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 4,
                            Name = "Product 7",
                            Price = 27m
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 4,
                            Name = "Product 8",
                            Price = 28m
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 2,
                            Name = "Product 9",
                            Price = 29m
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 3,
                            Name = "Product 10",
                            Price = 30m
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 4,
                            Name = "Product 11",
                            Price = 31m
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 4,
                            Name = "Product 12",
                            Price = 32m
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 3,
                            Name = "Product 13",
                            Price = 33m
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 3,
                            Name = "Product 14",
                            Price = 34m
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 5,
                            Name = "Product 15",
                            Price = 35m
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 1,
                            Name = "Product 16",
                            Price = 36m
                        },
                        new
                        {
                            ProductId = 17,
                            CategoryId = 1,
                            Name = "Product 17",
                            Price = 37m
                        },
                        new
                        {
                            ProductId = 18,
                            CategoryId = 2,
                            Name = "Product 18",
                            Price = 38m
                        },
                        new
                        {
                            ProductId = 19,
                            CategoryId = 4,
                            Name = "Product 19",
                            Price = 39m
                        },
                        new
                        {
                            ProductId = 20,
                            CategoryId = 1,
                            Name = "Product 20",
                            Price = 40m
                        },
                        new
                        {
                            ProductId = 21,
                            CategoryId = 1,
                            Name = "Product 21",
                            Price = 41m
                        },
                        new
                        {
                            ProductId = 22,
                            CategoryId = 4,
                            Name = "Product 22",
                            Price = 42m
                        },
                        new
                        {
                            ProductId = 23,
                            CategoryId = 4,
                            Name = "Product 23",
                            Price = 43m
                        },
                        new
                        {
                            ProductId = 24,
                            CategoryId = 4,
                            Name = "Product 24",
                            Price = 44m
                        },
                        new
                        {
                            ProductId = 25,
                            CategoryId = 1,
                            Name = "Product 25",
                            Price = 45m
                        },
                        new
                        {
                            ProductId = 26,
                            CategoryId = 5,
                            Name = "Product 26",
                            Price = 46m
                        },
                        new
                        {
                            ProductId = 27,
                            CategoryId = 2,
                            Name = "Product 27",
                            Price = 47m
                        },
                        new
                        {
                            ProductId = 28,
                            CategoryId = 4,
                            Name = "Product 28",
                            Price = 48m
                        },
                        new
                        {
                            ProductId = 29,
                            CategoryId = 1,
                            Name = "Product 29",
                            Price = 49m
                        },
                        new
                        {
                            ProductId = 30,
                            CategoryId = 2,
                            Name = "Product 30",
                            Price = 50m
                        },
                        new
                        {
                            ProductId = 31,
                            CategoryId = 1,
                            Name = "Product 31",
                            Price = 51m
                        },
                        new
                        {
                            ProductId = 32,
                            CategoryId = 3,
                            Name = "Product 32",
                            Price = 52m
                        },
                        new
                        {
                            ProductId = 33,
                            CategoryId = 2,
                            Name = "Product 33",
                            Price = 53m
                        },
                        new
                        {
                            ProductId = 34,
                            CategoryId = 5,
                            Name = "Product 34",
                            Price = 54m
                        },
                        new
                        {
                            ProductId = 35,
                            CategoryId = 2,
                            Name = "Product 35",
                            Price = 55m
                        },
                        new
                        {
                            ProductId = 36,
                            CategoryId = 4,
                            Name = "Product 36",
                            Price = 56m
                        },
                        new
                        {
                            ProductId = 37,
                            CategoryId = 3,
                            Name = "Product 37",
                            Price = 57m
                        },
                        new
                        {
                            ProductId = 38,
                            CategoryId = 2,
                            Name = "Product 38",
                            Price = 58m
                        },
                        new
                        {
                            ProductId = 39,
                            CategoryId = 3,
                            Name = "Product 39",
                            Price = 59m
                        },
                        new
                        {
                            ProductId = 40,
                            CategoryId = 2,
                            Name = "Product 40",
                            Price = 60m
                        },
                        new
                        {
                            ProductId = 41,
                            CategoryId = 4,
                            Name = "Product 41",
                            Price = 61m
                        },
                        new
                        {
                            ProductId = 42,
                            CategoryId = 5,
                            Name = "Product 42",
                            Price = 62m
                        },
                        new
                        {
                            ProductId = 43,
                            CategoryId = 5,
                            Name = "Product 43",
                            Price = 63m
                        },
                        new
                        {
                            ProductId = 44,
                            CategoryId = 5,
                            Name = "Product 44",
                            Price = 64m
                        },
                        new
                        {
                            ProductId = 45,
                            CategoryId = 1,
                            Name = "Product 45",
                            Price = 65m
                        },
                        new
                        {
                            ProductId = 46,
                            CategoryId = 1,
                            Name = "Product 46",
                            Price = 66m
                        },
                        new
                        {
                            ProductId = 47,
                            CategoryId = 1,
                            Name = "Product 47",
                            Price = 67m
                        },
                        new
                        {
                            ProductId = 48,
                            CategoryId = 2,
                            Name = "Product 48",
                            Price = 68m
                        },
                        new
                        {
                            ProductId = 49,
                            CategoryId = 4,
                            Name = "Product 49",
                            Price = 69m
                        },
                        new
                        {
                            ProductId = 50,
                            CategoryId = 1,
                            Name = "Product 50",
                            Price = 70m
                        },
                        new
                        {
                            ProductId = 51,
                            CategoryId = 2,
                            Name = "Product 51",
                            Price = 71m
                        },
                        new
                        {
                            ProductId = 52,
                            CategoryId = 1,
                            Name = "Product 52",
                            Price = 72m
                        },
                        new
                        {
                            ProductId = 53,
                            CategoryId = 1,
                            Name = "Product 53",
                            Price = 73m
                        },
                        new
                        {
                            ProductId = 54,
                            CategoryId = 3,
                            Name = "Product 54",
                            Price = 74m
                        },
                        new
                        {
                            ProductId = 55,
                            CategoryId = 2,
                            Name = "Product 55",
                            Price = 75m
                        },
                        new
                        {
                            ProductId = 56,
                            CategoryId = 5,
                            Name = "Product 56",
                            Price = 76m
                        },
                        new
                        {
                            ProductId = 57,
                            CategoryId = 2,
                            Name = "Product 57",
                            Price = 77m
                        },
                        new
                        {
                            ProductId = 58,
                            CategoryId = 2,
                            Name = "Product 58",
                            Price = 78m
                        },
                        new
                        {
                            ProductId = 59,
                            CategoryId = 3,
                            Name = "Product 59",
                            Price = 79m
                        },
                        new
                        {
                            ProductId = 60,
                            CategoryId = 1,
                            Name = "Product 60",
                            Price = 80m
                        },
                        new
                        {
                            ProductId = 61,
                            CategoryId = 3,
                            Name = "Product 61",
                            Price = 81m
                        },
                        new
                        {
                            ProductId = 62,
                            CategoryId = 5,
                            Name = "Product 62",
                            Price = 82m
                        },
                        new
                        {
                            ProductId = 63,
                            CategoryId = 3,
                            Name = "Product 63",
                            Price = 83m
                        },
                        new
                        {
                            ProductId = 64,
                            CategoryId = 1,
                            Name = "Product 64",
                            Price = 84m
                        },
                        new
                        {
                            ProductId = 65,
                            CategoryId = 2,
                            Name = "Product 65",
                            Price = 85m
                        },
                        new
                        {
                            ProductId = 66,
                            CategoryId = 2,
                            Name = "Product 66",
                            Price = 86m
                        },
                        new
                        {
                            ProductId = 67,
                            CategoryId = 2,
                            Name = "Product 67",
                            Price = 87m
                        },
                        new
                        {
                            ProductId = 68,
                            CategoryId = 4,
                            Name = "Product 68",
                            Price = 88m
                        },
                        new
                        {
                            ProductId = 69,
                            CategoryId = 2,
                            Name = "Product 69",
                            Price = 89m
                        },
                        new
                        {
                            ProductId = 70,
                            CategoryId = 2,
                            Name = "Product 70",
                            Price = 90m
                        },
                        new
                        {
                            ProductId = 71,
                            CategoryId = 3,
                            Name = "Product 71",
                            Price = 91m
                        },
                        new
                        {
                            ProductId = 72,
                            CategoryId = 5,
                            Name = "Product 72",
                            Price = 92m
                        },
                        new
                        {
                            ProductId = 73,
                            CategoryId = 4,
                            Name = "Product 73",
                            Price = 93m
                        },
                        new
                        {
                            ProductId = 74,
                            CategoryId = 2,
                            Name = "Product 74",
                            Price = 94m
                        },
                        new
                        {
                            ProductId = 75,
                            CategoryId = 3,
                            Name = "Product 75",
                            Price = 95m
                        },
                        new
                        {
                            ProductId = 76,
                            CategoryId = 2,
                            Name = "Product 76",
                            Price = 96m
                        },
                        new
                        {
                            ProductId = 77,
                            CategoryId = 4,
                            Name = "Product 77",
                            Price = 97m
                        },
                        new
                        {
                            ProductId = 78,
                            CategoryId = 4,
                            Name = "Product 78",
                            Price = 98m
                        },
                        new
                        {
                            ProductId = 79,
                            CategoryId = 4,
                            Name = "Product 79",
                            Price = 99m
                        },
                        new
                        {
                            ProductId = 80,
                            CategoryId = 1,
                            Name = "Product 80",
                            Price = 100m
                        },
                        new
                        {
                            ProductId = 81,
                            CategoryId = 5,
                            Name = "Product 81",
                            Price = 101m
                        },
                        new
                        {
                            ProductId = 82,
                            CategoryId = 1,
                            Name = "Product 82",
                            Price = 102m
                        },
                        new
                        {
                            ProductId = 83,
                            CategoryId = 5,
                            Name = "Product 83",
                            Price = 103m
                        },
                        new
                        {
                            ProductId = 84,
                            CategoryId = 1,
                            Name = "Product 84",
                            Price = 104m
                        },
                        new
                        {
                            ProductId = 85,
                            CategoryId = 5,
                            Name = "Product 85",
                            Price = 105m
                        },
                        new
                        {
                            ProductId = 86,
                            CategoryId = 5,
                            Name = "Product 86",
                            Price = 106m
                        },
                        new
                        {
                            ProductId = 87,
                            CategoryId = 3,
                            Name = "Product 87",
                            Price = 107m
                        },
                        new
                        {
                            ProductId = 88,
                            CategoryId = 5,
                            Name = "Product 88",
                            Price = 108m
                        },
                        new
                        {
                            ProductId = 89,
                            CategoryId = 3,
                            Name = "Product 89",
                            Price = 109m
                        },
                        new
                        {
                            ProductId = 90,
                            CategoryId = 3,
                            Name = "Product 90",
                            Price = 110m
                        },
                        new
                        {
                            ProductId = 91,
                            CategoryId = 3,
                            Name = "Product 91",
                            Price = 111m
                        },
                        new
                        {
                            ProductId = 92,
                            CategoryId = 2,
                            Name = "Product 92",
                            Price = 112m
                        },
                        new
                        {
                            ProductId = 93,
                            CategoryId = 4,
                            Name = "Product 93",
                            Price = 113m
                        },
                        new
                        {
                            ProductId = 94,
                            CategoryId = 2,
                            Name = "Product 94",
                            Price = 114m
                        },
                        new
                        {
                            ProductId = 95,
                            CategoryId = 4,
                            Name = "Product 95",
                            Price = 115m
                        },
                        new
                        {
                            ProductId = 96,
                            CategoryId = 5,
                            Name = "Product 96",
                            Price = 116m
                        },
                        new
                        {
                            ProductId = 97,
                            CategoryId = 2,
                            Name = "Product 97",
                            Price = 117m
                        },
                        new
                        {
                            ProductId = 98,
                            CategoryId = 5,
                            Name = "Product 98",
                            Price = 118m
                        },
                        new
                        {
                            ProductId = 99,
                            CategoryId = 3,
                            Name = "Product 99",
                            Price = 119m
                        },
                        new
                        {
                            ProductId = 100,
                            CategoryId = 5,
                            Name = "Product 100",
                            Price = 120m
                        });
                });

            modelBuilder.Entity("SportsStorenew.Domain.ProductImage", b =>
                {
                    b.Property<int>("ProductImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsThumbnail")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("SportsStorenew.Domain.Product", b =>
                {
                    b.HasOne("SportsStorenew.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SportsStorenew.Domain.ProductImage", b =>
                {
                    b.HasOne("SportsStorenew.Domain.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}