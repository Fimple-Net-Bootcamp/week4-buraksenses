﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtualPetCare.API.Persistence;

#nullable disable

namespace VirtualPetCare.API.Migrations
{
    [DbContext(typeof(VirtualPetCareDbContext))]
    [Migration("20231221144154_trainings")]
    partial class trainings
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("VirtualPetCare.API.Data.Entity.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float?>("DistanceTaken")
                        .HasColumnType("REAL");

                    b.Property<float>("Duration")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PetId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("VirtualPetCare.API.Data.Entity.Nutrition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float>("Calories")
                        .HasColumnType("REAL");

                    b.Property<string>("ForWhichPetJson")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Nutritions");
                });

            modelBuilder.Entity("VirtualPetCare.API.Domain.Entities.HealthStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CheckupDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PetId")
                        .HasColumnType("TEXT");

                    b.Property<string>("VaccinationStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("HealthStatusList");
                });

            modelBuilder.Entity("VirtualPetCare.API.Domain.Entities.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("NutritionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("NutritionId");

                    b.HasIndex("UserId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("VirtualPetCare.API.Domain.Entities.PetNutrition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("GivenDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("NutritionId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PetId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("NutritionId");

                    b.HasIndex("PetId");

                    b.ToTable("PetNutritions");
                });

            modelBuilder.Entity("VirtualPetCare.API.Domain.Entities.Training", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PetId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("VirtualPetCare.API.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("VirtualPetCare.API.Data.Entity.Activity", b =>
                {
                    b.HasOne("VirtualPetCare.API.Domain.Entities.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("VirtualPetCare.API.Domain.Entities.HealthStatus", b =>
                {
                    b.HasOne("VirtualPetCare.API.Domain.Entities.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("VirtualPetCare.API.Domain.Entities.Pet", b =>
                {
                    b.HasOne("VirtualPetCare.API.Data.Entity.Nutrition", null)
                        .WithMany("Pets")
                        .HasForeignKey("NutritionId");

                    b.HasOne("VirtualPetCare.API.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("VirtualPetCare.API.Domain.Entities.PetNutrition", b =>
                {
                    b.HasOne("VirtualPetCare.API.Data.Entity.Nutrition", "Nutrition")
                        .WithMany()
                        .HasForeignKey("NutritionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VirtualPetCare.API.Domain.Entities.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nutrition");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("VirtualPetCare.API.Domain.Entities.Training", b =>
                {
                    b.HasOne("VirtualPetCare.API.Domain.Entities.Pet", "Pet")
                        .WithMany("Trainings")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("VirtualPetCare.API.Data.Entity.Nutrition", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("VirtualPetCare.API.Domain.Entities.Pet", b =>
                {
                    b.Navigation("Trainings");
                });
#pragma warning restore 612, 618
        }
    }
}