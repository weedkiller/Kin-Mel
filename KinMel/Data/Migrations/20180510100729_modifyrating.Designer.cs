﻿// <auto-generated />
using System;
using KinMel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KinMel.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180510100729_modifyrating")]
    partial class modifyrating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KinMel.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AcceptedTerms");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("JoinDate");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfilePictureUrl");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("KinMel.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("KinMel.Models.ClassifiedAd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdDuration");

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Condition")
                        .IsRequired();

                    b.Property<string>("CreatedByUserId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("Delivery");

                    b.Property<double>("DeliveryCharges");

                    b.Property<string>("Description");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Features");

                    b.Property<string>("ImageUrls");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsSold");

                    b.Property<double>("Price");

                    b.Property<bool>("PriceNegotiable");

                    b.Property<string>("PrimaryImageUrl");

                    b.Property<string>("Slug");

                    b.Property<int>("SubCategoryId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("UsedFor");

                    b.Property<string>("WarrantyIncludes");

                    b.Property<string>("WarrantyPeriod");

                    b.Property<string>("WarrantyType");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("ClassifiedAd");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ClassifiedAd");
                });

            modelBuilder.Entity("KinMel.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action");

                    b.Property<string>("ActionController");

                    b.Property<int>("ActionId");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("IsRead");

                    b.Property<string>("NotificationFromId");

                    b.Property<string>("NotificationText");

                    b.Property<string>("NotificationToId");

                    b.HasKey("Id");

                    b.HasIndex("NotificationFromId");

                    b.HasIndex("NotificationToId");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("KinMel.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RatedById");

                    b.Property<string>("RatedForId");

                    b.Property<string>("Review");

                    b.Property<int>("Stars");

                    b.HasKey("Id");

                    b.HasIndex("RatedById");

                    b.HasIndex("RatedForId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("KinMel.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("KinMel.Models.ApparelsAndAccessories", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("ApparelsAndAccessories");

                    b.HasDiscriminator().HasValue("ApparelsAndAccessories");
                });

            modelBuilder.Entity("KinMel.Models.BeautyAndHealth", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("BeautyAndHealth");

                    b.HasDiscriminator().HasValue("BeautyAndHealth");
                });

            modelBuilder.Entity("KinMel.Models.BooksAndLearning", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");

                    b.Property<string>("Author");

                    b.Property<string>("Isbn");

                    b.ToTable("BooksAndLearning");

                    b.HasDiscriminator().HasValue("BooksAndLearning");
                });

            modelBuilder.Entity("KinMel.Models.Camera", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("Camera");

                    b.HasDiscriminator().HasValue("Camera");
                });

            modelBuilder.Entity("KinMel.Models.Car", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");

                    b.Property<string>("Brand");

                    b.Property<string>("Color");

                    b.Property<int>("DoorsNo");

                    b.Property<int>("Engine");

                    b.Property<string>("FuelType");

                    b.Property<string>("LotNo");

                    b.Property<int>("Mileage");

                    b.Property<string>("Model");

                    b.Property<int>("ModelYear");

                    b.Property<string>("RegisteredDistrict");

                    b.Property<int>("TotalKm");

                    b.Property<string>("Transmission");

                    b.Property<string>("Type");

                    b.ToTable("Car");

                    b.HasDiscriminator().HasValue("Car");
                });

            modelBuilder.Entity("KinMel.Models.Computer", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");

                    b.Property<double>("Battery");

                    b.Property<double>("GraphicsCard");

                    b.Property<double>("HDD");

                    b.Property<string>("Processor");

                    b.Property<string>("ProcessorGeneration");

                    b.Property<double>("Ram");

                    b.Property<double>("SSD");

                    b.Property<double>("ScreenSize");

                    b.Property<string>("ScreenType");

                    b.Property<string>("Type")
                        .HasColumnName("Computer_Type");

                    b.ToTable("Computer");

                    b.HasDiscriminator().HasValue("Computer");
                });

            modelBuilder.Entity("KinMel.Models.ComputerParts", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("ComputerParts");

                    b.HasDiscriminator().HasValue("ComputerParts");
                });

            modelBuilder.Entity("KinMel.Models.Electronics", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("Electronics");

                    b.HasDiscriminator().HasValue("Electronics");
                });

            modelBuilder.Entity("KinMel.Models.Furnitures", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("Furnitures");

                    b.HasDiscriminator().HasValue("Furnitures");
                });

            modelBuilder.Entity("KinMel.Models.HelpAndServices", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("HelpAndServices");

                    b.HasDiscriminator().HasValue("HelpAndServices");
                });

            modelBuilder.Entity("KinMel.Models.Jobs", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");

                    b.Property<string>("ContractFor");

                    b.Property<double>("Salary");

                    b.Property<string>("WorkingDays");

                    b.ToTable("Jobs");

                    b.HasDiscriminator().HasValue("Jobs");
                });

            modelBuilder.Entity("KinMel.Models.Mobile", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");

                    b.Property<double>("BackCamera");

                    b.Property<string>("Brand")
                        .HasColumnName("Mobile_Brand");

                    b.Property<string>("Color")
                        .HasColumnName("Mobile_Color");

                    b.Property<double>("FrontCamera");

                    b.Property<string>("Model")
                        .HasColumnName("Mobile_Model");

                    b.Property<string>("PhoneOs");

                    b.Property<int>("Ram")
                        .HasColumnName("Mobile_Ram");

                    b.Property<double>("ScreenSize")
                        .HasColumnName("Mobile_ScreenSize");

                    b.Property<double>("Storage");

                    b.ToTable("Mobile");

                    b.HasDiscriminator().HasValue("Mobile");
                });

            modelBuilder.Entity("KinMel.Models.MobileAccessories", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("MobileAccessories");

                    b.HasDiscriminator().HasValue("MobileAccessories");
                });

            modelBuilder.Entity("KinMel.Models.Motorcycle", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");

                    b.Property<string>("Brand")
                        .HasColumnName("Motorcycle_Brand");

                    b.Property<string>("Color")
                        .HasColumnName("Motorcycle_Color");

                    b.Property<int>("Engine")
                        .HasColumnName("Motorcycle_Engine");

                    b.Property<string>("LotNo")
                        .HasColumnName("Motorcycle_LotNo");

                    b.Property<int>("Mileage")
                        .HasColumnName("Motorcycle_Mileage");

                    b.Property<string>("Model")
                        .HasColumnName("Motorcycle_Model");

                    b.Property<int>("ModelYear")
                        .HasColumnName("Motorcycle_ModelYear");

                    b.Property<string>("RegisteredDistrict")
                        .HasColumnName("Motorcycle_RegisteredDistrict");

                    b.Property<int>("TotalKm")
                        .HasColumnName("Motorcycle_TotalKm");

                    b.Property<string>("Type")
                        .HasColumnName("Motorcycle_Type");

                    b.ToTable("Motorcycle");

                    b.HasDiscriminator().HasValue("Motorcycle");
                });

            modelBuilder.Entity("KinMel.Models.MusicInstruments", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("MusicInstruments");

                    b.HasDiscriminator().HasValue("MusicInstruments");
                });

            modelBuilder.Entity("KinMel.Models.PetsAndPetCare", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("PetsAndPetCare");

                    b.HasDiscriminator().HasValue("PetsAndPetCare");
                });

            modelBuilder.Entity("KinMel.Models.RealState", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");

                    b.Property<int>("Floors");

                    b.Property<string>("Furnishing");

                    b.Property<string>("LandSize");

                    b.Property<string>("PropertyType");

                    b.Property<int>("TotalRooms");

                    b.ToTable("RealState");

                    b.HasDiscriminator().HasValue("RealState");
                });

            modelBuilder.Entity("KinMel.Models.SportsAndFitness", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("SportsAndFitness");

                    b.HasDiscriminator().HasValue("SportsAndFitness");
                });

            modelBuilder.Entity("KinMel.Models.TabletsAndIPads", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");

                    b.Property<double>("BackCamera")
                        .HasColumnName("TabletsAndIPads_BackCamera");

                    b.Property<string>("Brand")
                        .HasColumnName("TabletsAndIPads_Brand");

                    b.Property<string>("Color")
                        .HasColumnName("TabletsAndIPads_Color");

                    b.Property<double>("FrontCamera")
                        .HasColumnName("TabletsAndIPads_FrontCamera");

                    b.Property<string>("Model")
                        .HasColumnName("TabletsAndIPads_Model");

                    b.Property<string>("PhoneOs")
                        .HasColumnName("TabletsAndIPads_PhoneOs");

                    b.Property<double>("Ram")
                        .HasColumnName("TabletsAndIPads_Ram");

                    b.Property<string>("ScreenSize")
                        .HasColumnName("TabletsAndIPads_ScreenSize");

                    b.Property<double>("Storage")
                        .HasColumnName("TabletsAndIPads_Storage");

                    b.ToTable("TabletsAndIPads");

                    b.HasDiscriminator().HasValue("TabletsAndIPads");
                });

            modelBuilder.Entity("KinMel.Models.ToysAndGames", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("ToysAndGames");

                    b.HasDiscriminator().HasValue("ToysAndGames");
                });

            modelBuilder.Entity("KinMel.Models.TravelAndTours", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("TravelAndTours");

                    b.HasDiscriminator().HasValue("TravelAndTours");
                });

            modelBuilder.Entity("KinMel.Models.VehiclesParts", b =>
                {
                    b.HasBaseType("KinMel.Models.ClassifiedAd");


                    b.ToTable("VehiclesParts");

                    b.HasDiscriminator().HasValue("VehiclesParts");
                });

            modelBuilder.Entity("KinMel.Models.ClassifiedAd", b =>
                {
                    b.HasOne("KinMel.Models.ApplicationUser", "CreatedByUser")
                        .WithMany("ClassifiedAds")
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("KinMel.Models.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KinMel.Models.Notification", b =>
                {
                    b.HasOne("KinMel.Models.ApplicationUser", "NotificationFrom")
                        .WithMany()
                        .HasForeignKey("NotificationFromId");

                    b.HasOne("KinMel.Models.ApplicationUser", "NotificationTo")
                        .WithMany("Notifications")
                        .HasForeignKey("NotificationToId");
                });

            modelBuilder.Entity("KinMel.Models.Rating", b =>
                {
                    b.HasOne("KinMel.Models.ApplicationUser", "RatedBy")
                        .WithMany()
                        .HasForeignKey("RatedById");

                    b.HasOne("KinMel.Models.ApplicationUser", "RatedFor")
                        .WithMany("Ratings")
                        .HasForeignKey("RatedForId");
                });

            modelBuilder.Entity("KinMel.Models.SubCategory", b =>
                {
                    b.HasOne("KinMel.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("KinMel.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("KinMel.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KinMel.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("KinMel.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
