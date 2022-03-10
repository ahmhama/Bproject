using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Checking> Checkings { get; set; }
        public DbSet<Testing> Testing { get; set; }
        public DbSet<Child> Child { get; set; }
        public DbSet<Diseases> Diseases { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<HealthOffice> HealthOffices { get; set; }
        public DbSet<MinistryAdministrator> MinistryAdministrator { get; set; }
        public DbSet<Relatives> Relatives { get; set; }
        public DbSet<VaccineCamping> VaccineCamping { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Vaccine> Vaccine { get; set; }
        public DbSet<VaccineTransaction> VaccineTranasaction { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Checking>(x => x.HasKey(aa => new { aa.ChildId, aa.DiseasesId, aa.doctorId }));

            builder.Entity<Checking>()
            .HasOne(u => u.Child)
            .WithMany(a => a.Checking)
            .HasForeignKey(aa => aa.ChildId);

            builder.Entity<Checking>()
            .HasOne(u => u.doctor)
            .WithMany(a => a.Checking)
            .HasForeignKey(aa => aa.doctorId);

            builder.Entity<Checking>()
            .HasOne(u => u.diseases)
            .WithMany(a => a.Checking)
            .HasForeignKey(aa => aa.DiseasesId);

            builder.Entity<VaccineTransaction>(x => x.HasKey(aa => new { aa.ChildId, aa.VaccineId, aa.doctorId }));
            
            builder.Entity<VaccineTransaction>()
            .HasOne(u => u.Child)
            .WithMany(a => a.VaccineTransactions)
            .HasForeignKey(aa => aa.ChildId);

            builder.Entity<VaccineTransaction>()
            .HasOne(u => u.Doctor)
            .WithMany(a => a.VaccineTransaction)
            .HasForeignKey(aa => aa.doctorId);

            builder.Entity<VaccineTransaction>()
            .HasOne(u => u.Vaccine)
            .WithMany(a => a.VaccineTranasaction)
            .HasForeignKey(aa => aa.VaccineId);

             builder.Entity<Event>(x => x.HasKey(aa => new { aa.ChildId, aa.VaccineCampingId, aa.doctorId }));
            
            builder.Entity<Event>()
            .HasOne(u => u.Child)
            .WithMany(a => a.Events)
            .HasForeignKey(aa => aa.ChildId);

            builder.Entity<Event>()
            .HasOne(u => u.doctor)
            .WithMany(a => a.Events)
            .HasForeignKey(aa => aa.doctorId);

            builder.Entity<Event>()
            .HasOne(u => u.VaccineCamping)
            .WithMany(a => a.Events)
            .HasForeignKey(aa => aa.VaccineCampingId);
        }
    }
}