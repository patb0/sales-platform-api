﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesPlatform.Infrastructure.Persistence;

#nullable disable

namespace SalesPlatform.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<string>("FlatNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Warsaw",
                            Country = 0,
                            FlatNumber = "1a",
                            Street = "Kwiatowa",
                            ZipCode = "00-000"
                        },
                        new
                        {
                            Id = 2,
                            City = "London",
                            Country = 1,
                            FlatNumber = "19",
                            Street = "Backer",
                            ZipCode = "93-400"
                        },
                        new
                        {
                            Id = 3,
                            City = "Kreta",
                            Country = 26,
                            FlatNumber = "10/2",
                            Street = "Backer",
                            ZipCode = "93-400"
                        },
                        new
                        {
                            Id = 4,
                            City = "Oslo",
                            Country = 12,
                            FlatNumber = "102a",
                            Street = "Lorem",
                            ZipCode = "93-400"
                        },
                        new
                        {
                            Id = 5,
                            City = "Amsterdam",
                            Country = 7,
                            FlatNumber = "88",
                            Street = "Lorem",
                            ZipCode = "93-400"
                        });
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmailAddress = "patbog@mail.com",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            Id = 2,
                            EmailAddress = "damian@mail.com",
                            PhoneNumber = "987654321"
                        },
                        new
                        {
                            Id = 3,
                            EmailAddress = "jan@mail.com",
                            PhoneNumber = "388499201"
                        },
                        new
                        {
                            Id = 4,
                            EmailAddress = "adas@pl.com",
                            PhoneNumber = "992003991"
                        },
                        new
                        {
                            Id = 5,
                            EmailAddress = "kasia@xp.com",
                            PhoneNumber = "9908882991"
                        });
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIP")
                        .HasMaxLength(10)
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("ContactId")
                        .IsUnique();

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            ContactId = 1,
                            Created = new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(89),
                            CreatedBy = "Admin",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            ContactId = 2,
                            Created = new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(154),
                            CreatedBy = "Admin",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 3,
                            ContactId = 3,
                            Created = new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(157),
                            CreatedBy = "Admin",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 4,
                            AddressId = 4,
                            ContactId = 4,
                            Created = new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(159),
                            CreatedBy = "Admin",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 5,
                            AddressId = 5,
                            ContactId = 5,
                            Created = new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(161),
                            CreatedBy = "Admin",
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Opinion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Opinions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            ProductId = 1,
                            Rating = 5
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            ProductId = 2,
                            Rating = 3
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            ProductId = 3,
                            Rating = 5
                        },
                        new
                        {
                            Id = 4,
                            Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            ProductId = 4,
                            Rating = 5
                        },
                        new
                        {
                            Id = 5,
                            Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            ProductId = 5,
                            Rating = 1
                        });
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("Condition")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(9,2)")
                        .HasDefaultValue(0m);

                    b.Property<int>("Quantity")
                        .HasMaxLength(999)
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<bool>("VAT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 0,
                            Condition = 0,
                            Created = new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(792),
                            CreatedBy = "Admin",
                            CustomerId = 1,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Name = "Product name1",
                            Price = 500m,
                            Quantity = 1,
                            StatusId = 1,
                            VAT = true
                        },
                        new
                        {
                            Id = 2,
                            Category = 4,
                            Condition = 0,
                            Created = new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(803),
                            CreatedBy = "Admin",
                            CustomerId = 1,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Name = "Product name2",
                            Price = 200m,
                            Quantity = 5,
                            StatusId = 1,
                            VAT = false
                        },
                        new
                        {
                            Id = 3,
                            Category = 2,
                            Condition = 0,
                            Created = new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(806),
                            CreatedBy = "Admin",
                            CustomerId = 2,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Name = "Product name3",
                            Price = 250m,
                            Quantity = 15,
                            StatusId = 1,
                            VAT = false
                        },
                        new
                        {
                            Id = 4,
                            Category = 3,
                            Condition = 0,
                            Created = new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(808),
                            CreatedBy = "Admin",
                            CustomerId = 3,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Name = "Product name 4",
                            Price = 99m,
                            Quantity = 1,
                            StatusId = 1,
                            VAT = true
                        },
                        new
                        {
                            Id = 5,
                            Category = 1,
                            Condition = 0,
                            Created = new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(811),
                            CreatedBy = "Admin",
                            CustomerId = 4,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Name = "Product name 5",
                            Price = 23m,
                            Quantity = 99,
                            StatusId = 1,
                            VAT = true
                        },
                        new
                        {
                            Id = 6,
                            Category = 4,
                            Condition = 0,
                            Created = new DateTime(2023, 4, 17, 22, 16, 6, 880, DateTimeKind.Local).AddTicks(813),
                            CreatedBy = "Admin",
                            CustomerId = 5,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Name = "Product name 6",
                            Price = 88m,
                            Quantity = 9,
                            StatusId = 1,
                            VAT = false
                        });
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Customer", b =>
                {
                    b.HasOne("SalesPlatform.Domain.Entities.Address", "Address")
                        .WithOne("Customer")
                        .HasForeignKey("SalesPlatform.Domain.Entities.Customer", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesPlatform.Domain.Entities.Contact", "Contact")
                        .WithOne("Customer")
                        .HasForeignKey("SalesPlatform.Domain.Entities.Customer", "ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("SalesPlatform.Domain.ValueObjects.PersonName", "CustomerName", b1 =>
                        {
                            b1.Property<int>("CustomerId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)")
                                .HasColumnName("LastName");

                            b1.HasKey("CustomerId");

                            b1.ToTable("Customers");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");

                            b1.HasData(
                                new
                                {
                                    CustomerId = 1,
                                    FirstName = "Patryk",
                                    LastName = "Boguslawski"
                                },
                                new
                                {
                                    CustomerId = 2,
                                    FirstName = "Damian",
                                    LastName = "Boguslawski"
                                },
                                new
                                {
                                    CustomerId = 3,
                                    FirstName = "Jan",
                                    LastName = "Kowalski"
                                },
                                new
                                {
                                    CustomerId = 4,
                                    FirstName = "Adam",
                                    LastName = "Kozak"
                                },
                                new
                                {
                                    CustomerId = 5,
                                    FirstName = "Katarzyna",
                                    LastName = "Szybka"
                                });
                        });

                    b.Navigation("Address");

                    b.Navigation("Contact");

                    b.Navigation("CustomerName")
                        .IsRequired();
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Opinion", b =>
                {
                    b.HasOne("SalesPlatform.Domain.Entities.Product", "Product")
                        .WithMany("Opinions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Product", b =>
                {
                    b.HasOne("SalesPlatform.Domain.Entities.Customer", "Customer")
                        .WithMany("Products")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("SalesPlatform.Domain.ValueObjects.ProductDetail", "ProductDetails", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("int");

                            b1.Property<string>("Color")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Country")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("ProducerName")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");

                            b1.HasData(
                                new
                                {
                                    ProductId = 1,
                                    Color = "Black",
                                    Country = "Poland",
                                    ProducerName = "Asus"
                                },
                                new
                                {
                                    ProductId = 2,
                                    Color = "Red",
                                    Country = "England",
                                    ProducerName = "Pepco"
                                },
                                new
                                {
                                    ProductId = 3,
                                    Color = "Blue",
                                    Country = "Czech",
                                    ProducerName = "Sparco"
                                },
                                new
                                {
                                    ProductId = 4,
                                    Color = "White",
                                    Country = "Norway",
                                    ProducerName = "Nike"
                                },
                                new
                                {
                                    ProductId = 5,
                                    Color = "Green",
                                    Country = "Finland",
                                    ProducerName = "Adidas"
                                },
                                new
                                {
                                    ProductId = 6,
                                    Color = "Purple",
                                    Country = "Denmark",
                                    ProducerName = "Pepco"
                                });
                        });

                    b.Navigation("Customer");

                    b.Navigation("ProductDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Address", b =>
                {
                    b.Navigation("Customer")
                        .IsRequired();
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Contact", b =>
                {
                    b.Navigation("Customer")
                        .IsRequired();
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Product", b =>
                {
                    b.Navigation("Opinions");
                });
#pragma warning restore 612, 618
        }
    }
}
