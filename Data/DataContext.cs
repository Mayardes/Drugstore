using drugstore.Models;
using Microsoft.EntityFrameworkCore;

namespace drugstore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt): base(opt)
        {
            Database.EnsureCreated();
        }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicalSpecialty> MedicalSpecialties { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>().Property(x => new { x.Name, x.Password}).IsRequired();
            modelBuilder.Entity<Administrator>().HasKey(x => x.Id);
        }
    }
}
