using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    class GHRepository<T> : IDataRepository<T>
    {
        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IQueryable<T>> includeFunction = null, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IQueryable<T>> includeFunction = null, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public DateTime GetSyncData()
        {
            throw new NotImplementedException();
        }

        public void Remove(object id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<T> newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
