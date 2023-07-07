using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.DataLayer.Services.interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<T> CreateEntity(T entity);
        public T UpdateEntity(T entity);
        public bool DeleteEntity(T entity);
        public Task<T> FindOne(Expression<Func<T, bool>> where = null);
        public Task<List<T>> Find(Expression<Func<T, bool>> where = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
    }
}
