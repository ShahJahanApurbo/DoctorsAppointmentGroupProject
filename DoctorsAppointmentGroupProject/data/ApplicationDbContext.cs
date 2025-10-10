using Microsoft.EntityFrameworkCore;
using DoctorsAppointmentGroupProject.Models;

namespace DoctorsAppointmentGroupProject.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
