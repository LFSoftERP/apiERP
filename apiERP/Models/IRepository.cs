using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ERP_COOPFAM.Model.Repository
{
    public interface IRepository<T>
        where T : class
    {
        void Update(T entity);
        void Delete(T entity);
        void Add(T entity);
        bool SaveChanges(string x);
        IQueryable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> where);
        bool Any(Expression<Func<T, bool>> where);
        void cadastra_erro(string _desc_erro, string _lugar, Exception ex = null);
        T FirstOrDefault(Expression<Func<T, bool>> where);
        IEnumerable<T> FindAsNoTracking(Expression<Func<T, bool>> where);
        T Consulta_Id(object id);        
    }
}
