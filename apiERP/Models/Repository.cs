using apiERP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;

namespace ERP_COOPFAM.Model.Repository
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly DbContext _context = new db_coopfamEntities();

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified; 
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Add(T entity)
        {
            if (entity != null)
            {
                _context.Set<T>().Add(entity);
            }
        }

        public bool SaveChanges(string _desc_lugar)
        {            
                try
                {
                    _context.SaveChanges();
                    return true;
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            cadastra_erro("Property: " + validationError.PropertyName + " Error: " +validationError.ErrorMessage,_desc_lugar);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    string erro = ex.Message.ToString();
                    if (ex.InnerException != null)
                        erro += " - " + ex.InnerException.Message.ToString();
                    if (ex.InnerException != null && ex.InnerException.InnerException != null)
                        erro += " - " + ex.InnerException.InnerException.Message.ToString();
                    if (ex.InnerException != null && ex.InnerException.InnerException != null && ex.InnerException.InnerException.InnerException != null)
                        erro += " - " + ex.InnerException.InnerException.InnerException.Message.ToString();

                    cadastra_erro(erro,_desc_lugar);
                    return false;
                }             
            
            return false;
        }

        private string verificaErroERetornaDescricao(Exception ex)
        {
            if (ex == null)
                return "";

            string erro = "";
            if (ex.InnerException != null)
            {
                erro += " - " + ex.InnerException.Message.ToString();
                if (ex.InnerException.InnerException != null)
                {
                    erro += " - " + ex.InnerException.InnerException.Message.ToString();
                    if (ex.InnerException.InnerException.InnerException.InnerException != null)
                        erro += " - " + ex.InnerException.InnerException.InnerException.Message.ToString();
                }
            }
            return erro;
        }


        public void cadastra_erro(string _desc_erro, string _lugar, Exception ex = null)
        {
            db_coopfamEntities db = new db_coopfamEntities();
            log_erro_do_sistema _log = new log_erro_do_sistema();
            _log.DATE = DateTime.Now;
            // _log.INT_ID_FUNCIONARIO = Controle_de_usuarios.Controle_Usuarios.get_id();
            _log.INT_ID_FUNCIONARIO =1;
            _log.TXT_ERRO = _desc_erro;
            _log.TXT_ERRO += verificaErroERetornaDescricao(ex);
            _log.TXT_ONDE = _lugar;
            db.Set<log_erro_do_sistema>().Add(_log);
            db.SaveChanges();
        }

        //Contato contato = repository.Find(c => c.Id == id).First();

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T Consulta_Id(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Any(Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().Any(where);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().FirstOrDefault(where);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> where)
        {
            //return _context.Set<T>().Where(where).AsNoTracking();
           return _context.Set<T>().Where(where);
        }

        public IEnumerable<T> FindAsNoTracking(Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().Where(where).AsNoTracking();
        }
        

        //public IEnumerable Selecionar(Expression<Func<T, int, bool>> selector, Expression<Func<T,  bool>> where)
        //{
        //    if (selector == null)
        //    {
        //        throw new ArgumentNullException(nameof(selector));
        //    }
        //    //return _context.Set<T>().Where(where).AsNoTracking();
        //    return _context.Set<T>().Select(selector).Where(where);
        //}

        //public static IQueryable<TResult> Select<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector);
        //public static IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);
    }
}