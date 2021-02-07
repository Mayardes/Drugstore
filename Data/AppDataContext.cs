using drugstore.Models;
using Microsoft.EntityFrameworkCore;

namespace drugstore.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> opt): base(opt)
        {
            //Database.EnsureCreated();
        }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicalSpecialty> MedicalSpecialties { get; set; }

    }
}
