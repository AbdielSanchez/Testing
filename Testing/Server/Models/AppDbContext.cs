using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Shared;

namespace Testing.Server.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { ID = 1, Name = "SD" });
            modelBuilder.Entity<Department>().HasData(
                new Department { ID = 2, Name = "A" });
            modelBuilder.Entity<Department>().HasData(
                new Department { ID = 3, Name = "B" });

            //Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                ID = 1,
                Name = "Sam",
                LastName = "Smith",
                BirthDate = new DateTime(1998, 11, 11),
                Gender = Gender.Female,
                DepartmentID = "1",
                Department = null
            }); ;
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                ID = 2,
                Name = "Andrés",
                LastName = "Fuentes",
                BirthDate = new DateTime(1996, 10, 21),
                Gender = Gender.Male,
                DepartmentID = "2",
                Department = null
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                ID = 3,
                Name = "Miku",
                LastName = "Hatsune",
                BirthDate = new DateTime(2007, 08, 31),
                Gender = Gender.Male,
                DepartmentID = "3",
                Department = null
            });


        }
    }
}
