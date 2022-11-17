using CompanyDataBase.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace CompanyDataBase.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasOne(E => E.Department)
                .WithMany(E => E.Employees)
                .HasForeignKey(E => E.departmentId);


            modelBuilder.Entity<EmployeeProject>()
                .HasKey(E => new { E.ProjectId, E.EmployeeId });

            modelBuilder.Entity<Dependants>()
                .HasKey(E => new { E.EmployeeId, E.Name });

            modelBuilder.Entity<DepartmentLocations>()
                .HasKey(E => new { E.DepartmentId, E.Location });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }

        public DbSet<Dependants> Dependants { get; set; }


    }
}
