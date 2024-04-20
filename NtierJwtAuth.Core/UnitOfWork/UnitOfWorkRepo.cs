using NtierJwtAuth.Core.Repository;
using NtierJwtAuth.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierJwtAuth.Core.UnitOfWork
{
    public class UnitOfWorkRepo : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        public IGenericRepository<Employee> Employees {  get; private set; }
        public IGenericRepository<Department> Departments { get; private set; }

        public UnitOfWorkRepo(ApplicationDbContext _context)
        {
            this.context = _context;
            this.Employees = new GenericRepository<Employee>(context);
            this.Departments = new GenericRepository<Department>(context);
        }

        public int Complete()
        {
           return  context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
