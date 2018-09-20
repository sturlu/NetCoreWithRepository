﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreWithRepository.Data.Context;

namespace NetCoreWithRepository.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180919110528_UpdateCategoryProp")]
    partial class UpdateCategoryProp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetCoreWithRepository.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Deneme");

                    b.Property<string>("ImageName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("SeoDescription");

                    b.Property<string>("SeoKeyword");

                    b.Property<string>("SeoTitle");

                    b.Property<string>("SeoUrl");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NetCoreWithRepository.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<string>("Body");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("ImageName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("SeoDescription");

                    b.Property<string>("SeoKeyword");

                    b.Property<string>("SeoTitle");

                    b.Property<string>("SeoUrl");

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("NetCoreWithRepository.Data.Entities.Product", b =>
                {
                    b.HasOne("NetCoreWithRepository.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
