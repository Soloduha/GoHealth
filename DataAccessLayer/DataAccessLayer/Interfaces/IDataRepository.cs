using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    /// <summary>
	/// Base IDataAccessLayer interface
	/// </summary>
	public interface IDataRepository<TEntity>
    {
        
        TEntity Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);
        
        void Remove(object id);
        
        void Remove(TEntity entity);
        
        TEntity Update(TEntity entity);
        
        void Update(IEnumerable<TEntity> newEntity);
        
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> includeFunction = null, bool asNoTracking = false);
        
        bool Any(Expression<Func<TEntity, bool>> predicate = null);
        
        TEntity GetSingle(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> includeFunction = null, bool asNoTracking = false);

        DateTime GetSyncData();
    }
}
