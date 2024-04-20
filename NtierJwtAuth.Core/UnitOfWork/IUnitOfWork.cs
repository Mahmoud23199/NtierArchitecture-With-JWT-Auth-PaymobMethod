using NtierJwtAuth.Core.Repository;
using NtierJwtAuth.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierJwtAuth.Core.UnitOfWork
{
     public interface IUnitOfWork:IDisposable
     {
         IGenericRepository<Employee> Employees { get;}
         IGenericRepository<Department>Departments  { get; }

        int Complete();
    }
}
