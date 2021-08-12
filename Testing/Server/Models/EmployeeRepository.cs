using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Shared;

namespace Testing.Server.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            if(employee.Department != null)
            {
                appDbContext.Entry(employee.Department).State = EntityState.Unchanged;
            }

            var result = await appDbContext.Employees.AddAsync(employee);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteEmployee(int id)
        {
            var result = await appDbContext.Employees.FirstOrDefaultAsync(e => e.ID == id);

            if(result != null)
            {
                appDbContext.Employees.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await appDbContext.Employees.Include(e => e.DepartmentID).FirstOrDefaultAsync(e => e.ID == id); 
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await appDbContext.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            IQueryable<Employee> query = appDbContext.Employees;

            if(!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.Name.Contains(name) || e.LastName.Contains(name));
            }
            if(gender != null)
            {
                query = query.Where(e => e.Gender == gender);
            }
            return await query.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await appDbContext.Employees.FirstOrDefaultAsync(e => e.ID == employee.ID);

            if(result != null)
            {
                result.Name = employee.Name;
                result.LastName = employee.LastName;
                result.BirthDate = employee.BirthDate;
                result.DepartmentID = employee.DepartmentID;

                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;   
        }
    }
}
