using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NtierJwtAuth.EF.Model
{
    public class Employee
    {
        [Required,Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public double Salary { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        //[JsonIgnore]
        public virtual Department? Department { get; set; }
    }
}
