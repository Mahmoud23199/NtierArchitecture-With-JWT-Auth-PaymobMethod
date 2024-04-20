using NtierJwtAuth.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NtierJwtAuth.Core.Repository
{
    public interface IGenericRepository<T> where T : class
    {
       Task<IEnumerable<T>> GetAll(string[] includes);
       Task<T> GetById(Expression<Func<T, bool>> match, string[] includs);
       Task Add(T Entity);
       Task Delete(Expression<Func<T, bool>> match);
       Task Update(Expression<Func<T, bool>> match, T Entity);
       Task<IEnumerable<T>> GetAllByDto(Expression<Func<T, bool>> match, string[] includes = null);


    }
}
