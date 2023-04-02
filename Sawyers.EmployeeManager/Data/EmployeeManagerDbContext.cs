using Microsoft.EntityFrameworkCore;
using Sawyers.EmployeeManager.Data.Models;

namespace Sawyers.EmployeeManager.Data
{
    public class EmployeeManagerDbContext : DbContext
    {
        public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options) : base(options) { }
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Management" },
                new Department { Id = 2, Name = "Engineering" },
                new Department { Id = 3, Name = "Marketing" },
                new Department { Id = 4, Name = "Human Resources" },
                new Department { Id = 5, Name = "IT" });

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FirstName = "Michael", LastName = "Scott", DepartmentId = 1 },
                new Employee { Id = 2, FirstName = "Montgomery", LastName = "Scott", DepartmentId = 2, IsDeveloper = true },
                new Employee { Id = 3, FirstName = "James", LastName = "Kirk", DepartmentId = 1 },
                new Employee { Id = 4, FirstName = "Qui-Gon", LastName = "Jinn", DepartmentId = 2, IsDeveloper = true },
                new Employee { Id = 5, FirstName = "Obi-Wan", LastName = "Kenobi", DepartmentId = 2, IsDeveloper = true },
                new Employee { Id = 6, FirstName = "Indiana", LastName = "Jones", DepartmentId = 1, IsDeveloper = true },
                new Employee { Id = 7, FirstName = "Toby", LastName = "Flenderson", DepartmentId = 4 },
                new Employee { Id = 8, FirstName = "Kevin", LastName = "Flynn", DepartmentId = 5 },
                new Employee { Id = 9, FirstName = "Spock", LastName = "Spock", DepartmentId = 3 },
                new Employee { Id = 10, FirstName = "Forrest", LastName = "Gump", DepartmentId = 5 });
        }
    }
}