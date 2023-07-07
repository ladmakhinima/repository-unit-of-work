using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApi.Core.Contexts;
using WebApi.DataLayer.Services.interfaces;

namespace WebApi.DataLayer.Services.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private WebApiCoreDBContext _context { get; set; }
        private DbSet<T> _db { get; set; }

        public GenericRepository(WebApiCoreDBContext context)
        {
            _context = context;
            _db = context.Set<T>();
        }

        public async Task<T> CreateEntity(T entity)
        {
            await _db.AddAsync(entity);
            return entity;
        }

        public bool DeleteEntity(T entity)
        {
            try
            {
                _db.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<T>> Find(
            Expression<Func<T, bool>> where = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            var query = _db.AsQueryable();

            if (where != null)
            {
                query.Where(where);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.ToListAsync();
        }

        public async Task<T> FindOne(Expression<Func<T, bool>> where = null)
        {
            return await _db.FirstOrDefaultAsync(where);
        }

        public T UpdateEntity(T entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
