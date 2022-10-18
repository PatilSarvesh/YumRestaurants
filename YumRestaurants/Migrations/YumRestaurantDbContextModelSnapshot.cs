﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YumRestaurants.Model.Data;

#nullable disable

namespace YumRestaurants.Migrations
{
    [DbContext(typeof(YumRestaurantDbContext))]
    partial class YumRestaurantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("YumRestaurants.Model.Entities.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"), 1L, 1);

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.ToTable("carts");
                });

            modelBuilder.Entity("YumRestaurants.Model.Entities.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuItemId"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateOfLaunch")
                        .HasColumnType("datetime2");

                    b.Property<bool>("freeDelivery")
                        .HasColumnType("bit");

                    b.HasKey("MenuItemId");

                    b.HasIndex("CartId");

                    b.ToTable("menuItems");
                });

            modelBuilder.Entity("YumRestaurants.Model.Entities.MenuItem", b =>
                {
                    b.HasOne("YumRestaurants.Model.Entities.Cart", null)
                        .WithMany("menuItemId")
                        .HasForeignKey("CartId");
                });

            modelBuilder.Entity("YumRestaurants.Model.Entities.Cart", b =>
                {
                    b.Navigation("menuItemId");
                });
#pragma warning restore 612, 618
        }
    }
}