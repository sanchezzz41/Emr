using System;
using Emr.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Emr.Database
{
    /// <summary>
    /// Класс для работы с бд
    /// </summary>
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opt):base(opt)
        {
            
        }

        /// <summary>
        /// Так объявляется таблица в бд
        /// </summary>
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Diagnos> Diagnoses { get; set; }
        public DbSet<Drag> Drags { get; set; }

        public DbSet<ElectronicPersonalMedicalRecord> ElectronicPersonalMedicalRecords { get; set; }
        public DbSet<Medic> Medics { get; set; }
        public DbSet<MedicalExamination> MedicalExaminations { get; set; }
        public DbSet<Metric> Metrics { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Research> Researches { get; set; }
        public DbSet<RecieptDrags> RecieptDragses { get; set; }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RecieptDrags>()
                .HasKey(x => new {x.DragGuid, x.RecipeGuid});
        }
    }
}
