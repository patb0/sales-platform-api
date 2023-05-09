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

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "patryk",
                            PasswordHash = "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Login = "damian",
                            PasswordHash = "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 3,
                            Login = "patrol",
                            PasswordHash = "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 4,
                            Login = "adam",
                            PasswordHash = "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 5,
                            Login = "kasia",
                            PasswordHash = "AQAAAAIAAYagAAAAEJaTsR64pp6Igk/NgiSK+R4ioUc9AUB375nT/1qv9yXNuYjjAiC+ZrI3sEhMLasdIQ==",
                            RoleId = 2
                        });
                });

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
                            City = "London",
                            Country = 1,
                            FlatNumber = "19",
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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
                            EmailAddress = "damian@mail.com",
                            PhoneNumber = "987654321"
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

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Opinion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Opinions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddedBy = "Jan Kowalski",
                            Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            ProductId = 1,
                            Rating = 5
                        },
                        new
                        {
                            Id = 2,
                            AddedBy = "Adam Kozak",
                            Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            ProductId = 2,
                            Rating = 3
                        },
                        new
                        {
                            Id = 3,
                            AddedBy = "Patryk Boguslawski",
                            Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            ProductId = 3,
                            Rating = 5
                        },
                        new
                        {
                            Id = 4,
                            AddedBy = "Katarzyna Szybka",
                            Comment = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            ProductId = 4,
                            Rating = 5
                        },
                        new
                        {
                            Id = 5,
                            AddedBy = "Damian Boguslawski",
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

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("VAT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 0,
                            Condition = 0,
                            Created = new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(1199),
                            CreatedBy = "Admin",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Name = "Product name1",
                            Price = 500m,
                            Quantity = 1,
                            StatusId = 1,
                            UserId = 1,
                            VAT = true
                        },
                        new
                        {
                            Id = 2,
                            Category = 4,
                            Condition = 0,
                            Created = new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(1210),
                            CreatedBy = "Admin",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Name = "Product name2",
                            Price = 200m,
                            Quantity = 5,
                            StatusId = 1,
                            UserId = 1,
                            VAT = false
                        },
                        new
                        {
                            Id = 3,
                            Category = 2,
                            Condition = 0,
                            Created = new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(1214),
                            CreatedBy = "Admin",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Name = "Product name3",
                            Price = 250m,
                            Quantity = 15,
                            StatusId = 1,
                            UserId = 2,
                            VAT = false
                        },
                        new
                        {
                            Id = 4,
                            Category = 3,
                            Condition = 0,
                            Created = new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(1218),
                            CreatedBy = "Admin",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Name = "Product name 4",
                            Price = 99m,
                            Quantity = 1,
                            StatusId = 1,
                            UserId = 3,
                            VAT = true
                        },
                        new
                        {
                            Id = 5,
                            Category = 1,
                            Condition = 0,
                            Created = new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(1222),
                            CreatedBy = "Admin",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Name = "Product name 5",
                            Price = 23m,
                            Quantity = 99,
                            StatusId = 1,
                            UserId = 4,
                            VAT = true
                        },
                        new
                        {
                            Id = 6,
                            Category = 4,
                            Condition = 0,
                            Created = new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(1225),
                            CreatedBy = "Admin",
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Name = "Product name 6",
                            Price = 88m,
                            Quantity = 9,
                            StatusId = 1,
                            UserId = 5,
                            VAT = false
                        });
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

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

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("ContactId")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            AddressId = 1,
                            ContactId = 1,
                            Created = new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(662),
                            CreatedBy = "Admin",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 2,
                            AddressId = 2,
                            ContactId = 2,
                            Created = new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(694),
                            CreatedBy = "Admin",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 3,
                            AccountId = 3,
                            AddressId = 3,
                            ContactId = 3,
                            Created = new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(696),
                            CreatedBy = "Admin",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 4,
                            AccountId = 4,
                            AddressId = 4,
                            ContactId = 4,
                            Created = new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(698),
                            CreatedBy = "Admin",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 5,
                            AccountId = 5,
                            AddressId = 5,
                            ContactId = 5,
                            Created = new DateTime(2023, 5, 9, 22, 28, 8, 74, DateTimeKind.Local).AddTicks(700),
                            CreatedBy = "Admin",
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Account", b =>
                {
                    b.HasOne("SalesPlatform.Domain.Entities.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Image", b =>
                {
                    b.HasOne("SalesPlatform.Domain.Entities.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
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
                    b.HasOne("SalesPlatform.Domain.Entities.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("SalesPlatform.Domain.ValueObjects.ProductDetail", "ProductDetail", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("int");

                            b1.Property<string>("Color")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)")
                                .HasColumnName("Color");

                            b1.Property<string>("Country")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)")
                                .HasColumnName("Country");

                            b1.Property<string>("ProducerName")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)")
                                .HasColumnName("ProducerName");

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

                    b.Navigation("ProductDetail")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.User", b =>
                {
                    b.HasOne("SalesPlatform.Domain.Entities.Account", "Account")
                        .WithOne("User")
                        .HasForeignKey("SalesPlatform.Domain.Entities.User", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesPlatform.Domain.Entities.Address", "Address")
                        .WithOne("User")
                        .HasForeignKey("SalesPlatform.Domain.Entities.User", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesPlatform.Domain.Entities.Contact", "Contact")
                        .WithOne("User")
                        .HasForeignKey("SalesPlatform.Domain.Entities.User", "ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("SalesPlatform.Domain.ValueObjects.PersonName", "UserName", b1 =>
                        {
                            b1.Property<int>("UserId")
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

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.HasData(
                                new
                                {
                                    UserId = 1,
                                    FirstName = "Patryk",
                                    LastName = "Boguslawski"
                                },
                                new
                                {
                                    UserId = 2,
                                    FirstName = "Damian",
                                    LastName = "Boguslawski"
                                },
                                new
                                {
                                    UserId = 3,
                                    FirstName = "Jan",
                                    LastName = "Kowalski"
                                },
                                new
                                {
                                    UserId = 4,
                                    FirstName = "Adam",
                                    LastName = "Kozak"
                                },
                                new
                                {
                                    UserId = 5,
                                    FirstName = "Katarzyna",
                                    LastName = "Szybka"
                                });
                        });

                    b.Navigation("Account");

                    b.Navigation("Address");

                    b.Navigation("Contact");

                    b.Navigation("UserName")
                        .IsRequired();
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Account", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Address", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Contact", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Opinions");
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("SalesPlatform.Domain.Entities.User", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
