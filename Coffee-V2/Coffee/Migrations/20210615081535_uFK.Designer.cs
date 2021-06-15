﻿// <auto-generated />
using System;
using Coffee.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Coffee.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210615081535_uFK")]
    partial class uFK
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

                    b.Property<int>("RoasterID")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RoasterID");

                    b.ToTable("Beans");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Country = "Colombia",
                            Image = "https://cdn.shopify.com/s/files/1/0028/9085/8569/products/37_600x.png?v=1621461202",
                            Name = "Tuwaiq",
                            RoasterID = 2,
                            Type = "Washed"
                        },
                        new
                        {
                            ID = 2,
                            Country = "Guatemala",
                            Image = "https://cdn.shopify.com/s/files/1/0028/9085/8569/products/36_b624fe7b-9f13-4c19-bf4b-3f8de041b668_1200x.png?v=1621461554",
                            Name = "Qiddiya",
                            RoasterID = 2,
                            Type = "Washed"
                        },
                        new
                        {
                            ID = 3,
                            Country = "El Salvador",
                            Image = "https://camelstep.com/media/catalog/product/cache/cb1cf9ef08bd8ac078031d7ecd205277/_/-/_-__1_8.jpg",
                            Name = "El Salvador Baraona",
                            RoasterID = 4,
                            Type = "Natural"
                        },
                        new
                        {
                            ID = 4,
                            Country = "Ethiopia",
                            Image = "https://camelstep.com/media/catalog/product/cache/cb1cf9ef08bd8ac078031d7ecd205277/_/-/_-__1_5.jpg",
                            Name = "Ethiopia Ariti",
                            RoasterID = 4,
                            Type = "Natural"
                        },
                        new
                        {
                            ID = 5,
                            Country = "Uganda",
                            Image = "https://cdn.salla.sa/WyvX/PJUADylqF3BnEfwx7oqnmt8WwNV721uy1aaNc829.jpg",
                            Name = "Mananasi Espresso",
                            RoasterID = 3,
                            Type = "Natural"
                        },
                        new
                        {
                            ID = 6,
                            Country = "Ethiopia",
                            Image = "https://octave.coffee/wp-content/uploads/2021/04/chilbisa.jpg",
                            Name = "Chelbesa",
                            RoasterID = 1,
                            Type = "Natural"
                        });
                });

            modelBuilder.Entity("Coffee.Models.Recommendation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvailabilityLoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Recommendations");
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

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Roasteries");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Image = "https://media.zid.store/cdbbc706-61b2-4d93-9791-9f65743fe34b/ac8422ff-c987-4f26-8185-8c5cfe0464b9.jpeg",
                            Location = "Maddinah",
                            Name = "Kiffa Roaster",
                            Rate = 4.4000000000000004
                        },
                        new
                        {
                            ID = 2,
                            Image = "https://pbs.twimg.com/profile_images/1313161853045035008/womhVuch_400x400.jpg",
                            Location = "Riyadh",
                            Name = "Arriyadh Roaster",
                            Rate = 4.5999999999999996
                        },
                        new
                        {
                            ID = 3,
                            Image = "https://modernsupply.com.sa/wp-content/uploads/2021/03/31.jpg",
                            Location = "Jeddah",
                            Name = "Suwaa Roaster",
                            Rate = 4.5
                        },
                        new
                        {
                            ID = 4,
                            Image = "http://cdn.shopify.com/s/files/1/0257/0046/6776/collections/image_2d2722a5-3abe-4199-b964-5859ca7b790c_1200x1200.png?v=1584446917",
                            Location = "Khobar",
                            Name = "Camel Step Roaster",
                            Rate = 4.2999999999999998
                        });
                });

            modelBuilder.Entity("Coffee.Models.Tool", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Tools");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "380ml black stainless steel steam jug\r\n             Smooth design and tapered tip for easy drawing and pour control\r\n             in blue",
                            Image = "https://cdn.shopify.com/s/files/1/0028/9085/8569/products/DSC2671_1000x.jpg?v=1599727765",
                            Name = "TASH Steamer Jug Navy Blue Sharp"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Stainless steel exposed port filter with black rod Size 54 mm\r\n             Compatible with Breville Barista Express - Sage Machines",
                            Image = "https://cdn.shopify.com/s/files/1/0028/9085/8569/products/DSC3839_1000x.jpg?v=1599727217",
                            Name = "Tach port filter exposed"
                        },
                        new
                        {
                            ID = 3,
                            Description = "The Tach Coffee Dispenser The espresso surface dispenser allows for the desired depth to be adjusted to ensure perfect dispensing every time.\r\n              53 mm in size",
                            Image = "https://cdn.shopify.com/s/files/1/0028/9085/8569/products/Artboard_7_21f579be-9c5b-413e-8612-6b47f6e76df1.jpg?v=1599734667",
                            Name = "Tach coffee dispenser"
                        });
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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Coffee.Models.Bean", b =>
                {
                    b.HasOne("Coffee.Models.Roastery", "Roaster")
                        .WithMany("Beans")
                        .HasForeignKey("RoasterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roaster");
                });

            modelBuilder.Entity("Coffee.Models.Recommendation", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Users")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Users");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Coffee.Models.Roastery", b =>
                {
                    b.Navigation("Beans");
                });
#pragma warning restore 612, 618
        }
    }
}