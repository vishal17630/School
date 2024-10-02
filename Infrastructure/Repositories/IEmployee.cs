using Infrastructure.Data.Model.Common;
using Infrastructure.Data.Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
    {
        public interface IEmployeeService
        {
            Task<IEnumerable<Employee>> GetEmployee();
          
        }

   
   
    
}
