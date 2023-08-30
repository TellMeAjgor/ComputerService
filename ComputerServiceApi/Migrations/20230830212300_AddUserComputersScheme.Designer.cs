﻿// <auto-generated />
using System;
using ComputerService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComputerService.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230830212300_AddUserComputersScheme")]
    partial class AddUserComputersScheme
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ComputerServiceModels.Models.Entities.Computer", b =>
                {
                    b.Property<Guid>("ComputerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Case")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GraphicsCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Motherboard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperaionSystem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerSuply")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComputerId");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("ComputerServiceModels.Models.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ComputerServiceModels.Models.Entities.UserComputers", b =>
                {
                    b.Property<Guid>("UserComputersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ComputerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserComputersId");

                    b.HasIndex("ComputerId");

                    b.HasIndex("UserId");

                    b.ToTable("UserComputers");
                });

            modelBuilder.Entity("ComputerServiceModels.Models.Entities.UserComputers", b =>
                {
                    b.HasOne("ComputerServiceModels.Models.Entities.Computer", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComputerServiceModels.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Computer");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
