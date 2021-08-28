
using Clinic_Management_API.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Clinic_Management_API.Models
{
    public class ClinicDbContext : IdentityDbContext<AppUser> 
    {
        public ClinicDbContext(DbContextOptions<ClinicDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AppUserConfigurations());
            modelBuilder.ApplyConfiguration(new CheckUpConfigurations());
            modelBuilder.ApplyConfiguration(new EquipmentConfigurations());
            modelBuilder.ApplyConfiguration(new TreatmentConfigurations());
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<CheckUp> CheckUps { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
    }
}