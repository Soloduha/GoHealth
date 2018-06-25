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

        TEntity FindById(int id);

        TEntity GetEntity(Expression<Func<TEntity, bool>> predicate = null);

        IEnumerable<TEntity> GetEntities(Expression<Func<TEntity, bool>> predicate = null);

        void Remove(object id);
        
        void Remove(TEntity entity);
        
        TEntity Update(TEntity entity);
        
        void Update(IEnumerable<TEntity> newEntity);
        
        bool Any(Expression<Func<TEntity, bool>> predicate = null);
    }
}
