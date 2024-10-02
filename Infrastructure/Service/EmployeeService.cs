using Infrastructure.Data;
using Infrastructure.Data.Model.Employee;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDBcontext _context;

        public EmployeeService(AppDBcontext context)
        {
            _context = context;
        }
       public async Task<IEnumerable<Employee>> GetEmployee()
        {
            try
            {
                var activeEmployee = await _context.Employee
                                            .Where(c => (bool)c.IsActive == true)
                                            .ToListAsync();
                return activeEmployee;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
        
}