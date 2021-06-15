﻿// <auto-generated />
using Coffee.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Coffee.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210613214617_insertBeans")]
    partial class insertBeans
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Coffee.Models.Bean", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Beans");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Country = "Colombia",
                            Image = "https://cdn.shopify.com/s/files/1/0028/9085/8569/products/37_600x.png?v=1621461202",
                            Name = "Tuwaiq",
                            Type = "Washed"
                        },
                        new
                        {
                            ID = 2,
                            Country = "Guatemala",
                            Image = "https://cdn.shopify.com/s/files/1/0028/9085/8569/products/36_b624fe7b-9f13-4c19-bf4b-3f8de041b668_1200x.png?v=1621461554",
                            Name = "Qiddiya",
                            Type = "Washed"
                        },
                        new
                        {
                            ID = 3,
                            Country = "El Salvador",
                            Image = "https://camelstep.com/media/catalog/product/cache/cb1cf9ef08bd8ac078031d7ecd205277/_/-/_-__1_8.jpg",
                            Name = "El Salvador Baraona",
                            Type = "Natural"
                        },
                        new
                        {
                            ID = 4,
                            Country = "Ethiopia",
                            Image = "https://camelstep.com/media/catalog/product/cache/cb1cf9ef08bd8ac078031d7ecd205277/_/-/_-__1_5.jpg",
                            Name = "Ethiopia Ariti",
                            Type = "Natural"
                        },
                        new
                        {
                            ID = 5,
                            Country = "Uganda",
                            Image = "https://cdn.salla.sa/WyvX/PJUADylqF3BnEfwx7oqnmt8WwNV721uy1aaNc829.jpg",
                            Name = "Mananasi Espresso",
                            Type = "Natural"
                        },
                        new
                        {
                            ID = 6,
                            Country = "Ethiopia",
                            Image = "https://media.zid.store/52ed14bd-6baf-41c5-b177-f31d72230645/416c2414-507d-4225-89a2-80f5d789861b.png",
                            Name = "Chelbesa",
                            Type = "Natural"
                        });
                });

            modelBuilder.Entity("Coffee.Models.Roastery", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Roasteries");
                });
#pragma warning restore 612, 618
        }
    }
}
