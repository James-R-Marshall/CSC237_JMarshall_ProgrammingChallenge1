﻿// <auto-generated />
using System;
using CSC237_JMarshall_ProgrammingChallenge1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSC237_JMarshall_ProgrammingChallenge1.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CSC237_JMarshall_ProgrammingChallenge1.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            categoryName = "family"
                        },
                        new
                        {
                            CategoryID = 2,
                            categoryName = "friend"
                        },
                        new
                        {
                            CategoryID = 3,
                            categoryName = "Work"
                        },
                        new
                        {
                            CategoryID = 4,
                            categoryName = "N/A"
                        });
                });

            modelBuilder.Entity("CSC237_JMarshall_ProgrammingChallenge1.Models.Contact", b =>
                {
                    b.Property<int>("contactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contactID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            contactID = 1,
                            CategoryID = 2,
                            dateAdded = new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            email = "james_marshall48@aol.com",
                            firstName = "James",
                            lastName = "marshall",
                            organization = "NONE",
                            phone = "720-965-1983"
                        },
                        new
                        {
                            contactID = 2,
                            CategoryID = 1,
                            dateAdded = new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            email = "philip.marshall123456789@gmail.com",
                            firstName = "Philip",
                            lastName = "marshall",
                            organization = "Cresco",
                            phone = "720-965-2248"
                        },
                        new
                        {
                            contactID = 3,
                            CategoryID = 1,
                            dateAdded = new DateTime(2020, 2, 16, 13, 49, 47, 360, DateTimeKind.Local).AddTicks(8459),
                            email = "sarah.carpenteyro@gmail.com",
                            firstName = "Sarah",
                            lastName = "marshall",
                            phone = "720-965-1111"
                        });
                });

            modelBuilder.Entity("CSC237_JMarshall_ProgrammingChallenge1.Models.Contact", b =>
                {
                    b.HasOne("CSC237_JMarshall_ProgrammingChallenge1.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
