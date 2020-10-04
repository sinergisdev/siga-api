using Microsoft.EntityFrameworkCore;
using siga.infrastructure.Context;
using siga.infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace siga.infrastructure.Repository
{
    public class Repository<T> : IDisposable, IGenericRepository<T> where T : EntityBase
    {

        private readonly SigaDbContext _dbContext;

        public Repository(SigaDbContext dbContext) : base()
        {
            _dbContext = dbContext;
        }

        public void Delete(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("La Entidad no debe ser nula");
            }

            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();

        }

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }

        }

        public List<T> FindAllWhere(Func<T, bool> criteria)
        {
            return _dbContext.Set<T>().Where(criteria).ToList();
        }

        public T Get(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().AsEnumerable();

        }

        public void Include<TProperty>(System.Linq.Expressions.Expression<Func<T, TProperty>> navigationPropertyPath)
        {
            _dbContext.Set<T>().Include(navigationPropertyPath);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("La entidad no puede ser nula");
            }
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();

        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();
        }

        public bool Exists(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Any(predicate);
        }

       
    }
}
