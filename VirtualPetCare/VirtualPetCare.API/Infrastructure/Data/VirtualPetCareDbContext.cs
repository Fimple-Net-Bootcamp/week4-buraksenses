﻿using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Entities;

namespace VirtualPetCare.API.Persistence;

public class VirtualPetCareDbContext : DbContext
{
    public VirtualPetCareDbContext(DbContextOptions<VirtualPetCareDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pet>()
            .HasMany(p => p.SocialInteractions)
            .WithMany(s => s.Pets);
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Pet> Pets { get; set; }

    public DbSet<Activity> Activities{ get; set; }

    public DbSet<HealthStatus> HealthStatusList { get; set; }

    public DbSet<Nutrition> Nutritions { get; set; }

    public DbSet<PetNutrition> PetNutritions { get; set; }

    public DbSet<Training> Trainings { get; set; }

    public DbSet<SocialInteraction> SocialInteractions { get; set; }
}