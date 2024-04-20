using NtierJwtAuth.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierJwtAuth.Core.Dtos
{
    public class AllEmpWithDept
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string DeptName { get; set; }
        public string DeptManagerName { get; set; }

        
    }
}
