using Microsoft.EntityFrameworkCore;
using Employee.Models;

namespace Employee.Data;

public class ApplicationDbContext : DbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
   {

   }

   public DbSet<EmployeeEntity> Employees { get; set; }
   public DbSet<EmployeeFamilyEntity> EmployeeFamily { get; set; }
}
