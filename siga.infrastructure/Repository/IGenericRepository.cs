using siga.infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace siga.infrastructure.Repository
{
    public interface IGenericRepository<T> where T : EntityBase
    {

        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> FindAllWhere(Func<T, bool> criteria);
        void Include<TProperty>(Expression<Func<T, TProperty>> navigationPropertyPath);
        bool Exists(Expression<Func<T, bool>> predicate);
    }
}
