using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NtierJwtAuth.EF.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ManagerName { get; set; }

        //[JsonIgnore]
        public ICollection<Employee> Employees { get; set; } =new List<Employee>();

    }
}
