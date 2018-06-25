using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GHRepository<TEntity> : IDataRepository<TEntity> where TEntity:class, IBaseEntity
    {
        DbContext _context;
        DbSet<TEntity> _dbSet;

        public GHRepository()
        {
            _context = new MyContext();
            _dbSet = _context.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {   
            var result = _dbSet.Add(entity);
            _context.SaveChanges();
            return result;
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _dbSet.Add(entity);
            }
            _context.SaveChanges();
        }

        public TEntity FindById(int id)
        {
            return _dbSet.FirstOrDefault(x=>x.Id==id);
        }

        public TEntity GetEntity(Expression<Func<TEntity, bool>> predicate = null)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> GetEntities(Expression<Func<TEntity, bool>> predicate = null)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate = null)
        {
            return _dbSet.Any(predicate);
        }


        public void Remove(object id)
        {
            TEntity entity=_dbSet.Find(id);
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public TEntity Update(TEntity entity)
        {
            //var result = _dbSet.Attach(entity);
            //_context.En;
            //_context.SaveChanges();
            return null;
        }

        public void Update(IEnumerable<TEntity> newEntity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
