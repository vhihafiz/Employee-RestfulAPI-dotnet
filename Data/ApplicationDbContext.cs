using EmployeeBackOffice.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeBackOffice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
