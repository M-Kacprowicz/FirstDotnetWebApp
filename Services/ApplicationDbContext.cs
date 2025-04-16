using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Employee> Employees {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var employee_one = new Employee() {Id = Guid.NewGuid(), Name = "Jan", Surname = "Kowalski", Departament = "IT", BaseSalary = 5000,
                MonthlyBonus = 100, CreatedAtUtc = DateTime.UtcNow};
            var employee_two = new Employee() {Id = Guid.NewGuid(), Name = "Andrzej", Surname = "Kowalski", Departament = "Maintenance", BaseSalary = 3000,
                MonthlyBonus = 150, CreatedAtUtc = DateTime.UtcNow};
            var employee_three = new Employee() {Id = Guid.NewGuid(), Name = "Paweł", Surname = "Janusz", Departament = "Engineering", BaseSalary = 4000,
                MonthlyBonus = 120, CreatedAtUtc = DateTime.UtcNow};
            var employee_four = new Employee() {Id = Guid.NewGuid(), Name = "Joanna", Surname = "Niewiadoma", Departament = "HR", BaseSalary = 4500,
                MonthlyBonus = 50, CreatedAtUtc = DateTime.UtcNow};

            modelBuilder.Entity<Employee>().HasData(employee_one, employee_two, employee_three, employee_four);
        }
    }
}