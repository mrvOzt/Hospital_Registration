using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semafor_Hospital_Registrastion_System.Models
{
    public class ApplicationContext : DbContext
    {
       public ApplicationContext(DbContextOptions options) : base(options)
       {
       }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Visit> visits { get; set; }

        public DbSet<User> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Visit>()
                .HasKey(v => v.visit_id); // Birincil anahtarın yapılandırılması
            modelBuilder.Entity<Visit>()
                .HasOne(v => v.Patient)
                .WithMany(p => p.Visits)
                .HasForeignKey(v => v.patient_id);
        }

        public int SelectedPatientId { get; set; }
        




    }
}
