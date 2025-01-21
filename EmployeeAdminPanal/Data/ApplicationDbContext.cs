using EmployeeAdminPanal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPanal.Data
{
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        //{

        //}
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }  

    }
    
    
}
