using NtierJwtAuth.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierJwtAuth.Core.Dtos
{
    public class DeptWithAllEmp
    {
        public int id { get; set; }
        public string name { get; set; }
        public string managerName { get; set; }

        public List<EmployeeDto>employeesByDept { get; set; }
    }
}
