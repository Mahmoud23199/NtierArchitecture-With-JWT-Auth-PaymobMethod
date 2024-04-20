using Microsoft.EntityFrameworkCore;
using NtierJwtAuth.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NtierJwtAuth.Core.Repository
{
    public class GenericRepository<T>:IGenericRepository<T> where T : class
    {
        ApplicationDbContext applicationDbContext { get; }

        public GenericRepository(ApplicationDbContext _applicationDbContext)
        {
            this.applicationDbContext = _applicationDbContext;
        }

        public async Task<IEnumerable<T>> GetAll(string[] includes=null)
        {
            IQueryable<T> query = applicationDbContext.Set<T>();

            if(includes != null)
            { 
                foreach(var include in includes) 
                {
                    query = query.Include(include);
                }
            }

            return await query.ToListAsync();
        }
        public async Task<IEnumerable<T>> GetAllByDto(Expression<Func<T,bool>> match,string[] includes = null)
        {
            IQueryable<T> query = applicationDbContext.Set<T>();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.Where(match).ToListAsync();
        }

        public async Task<T> GetById(Expression<Func<T,bool>>match, string[] includes = null)
        {
            IQueryable<T> query = applicationDbContext.Set<T>();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.FirstOrDefaultAsync(match);
        }


        public async Task Add(T Entity)
        {
            await applicationDbContext.Set<T>().AddAsync(Entity);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task Update(Expression<Func<T, bool>> match, T Entity)
        {
            var item = await GetById(match);

            if(item != null) 
            { 
                 applicationDbContext.Entry(item).CurrentValues.SetValues(Entity);

                await applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task Delete(Expression<Func<T, bool>> match)
        {
            var item = await GetById(match);

            if (item != null)
            {
                applicationDbContext.Set<T>().Remove(item);
                await applicationDbContext.SaveChangesAsync();

            }
        }
    }
}
