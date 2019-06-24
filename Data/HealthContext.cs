using HealthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthAPI.Data
{
        public class HealthContext : DbContext {
            public HealthContext (DbContextOptions<HealthContext> options) : base (options) { }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
            }
            public DbSet<Ailment> Ailments { get; set; }
            public DbSet<Medication> Medications { get; set; }
            public DbSet<Patient> Patients { get; set; }
        }
    
    
        
    
}