﻿// <auto-generated />
using BillLibrary.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BillLibrary.Migrations
{
    [DbContext(typeof(BillDBContext))]
    [Migration("20240718091616_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BillLibrary.Modal.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("TotalAmt")
                        .IsRequired()
                        .HasColumnType("Text");

                    b.Property<string>("TotalItem")
                        .IsRequired()
                        .HasColumnType("Text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BillId");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("BillLibrary.Modal.Items", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Text");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("Text");

                    b.Property<string>("Qty")
                        .IsRequired()
                        .HasColumnType("Text");

                    b.HasKey("ItemId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("BillLibrary.Modal.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("Text");

                    b.Property<string>("Qty")
                        .IsRequired()
                        .HasColumnType("Text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("ItemId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BillLibrary.Modal.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BillLibrary.Modal.Bill", b =>
                {
                    b.HasOne("BillLibrary.Modal.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BillLibrary.Modal.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BillLibrary.Modal.Order", b =>
                {
                    b.HasOne("BillLibrary.Modal.Items", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}
