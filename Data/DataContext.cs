using drugstore.Models;
using Microsoft.EntityFrameworkCore;

namespace drugstore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt): base(opt)
        {

        }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicalSpecialty> MedicalSpecialties { get; set; }


    }
}
