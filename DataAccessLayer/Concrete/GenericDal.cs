using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccessLayer.Concrete
{
    public class GenericDal<T> : IGenericDal<T> where T : class
    {
        SalesForceEntities db = new SalesForceEntities();
        public void Add(T Entity)
        {
            db.Entry(Entity).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Delete(T Entity)
        {
            db.Entry(Entity).State = EntityState.Deleted;
            db.SaveChanges();
        }

 
        public void Update(T Entity)
        {
            db.Entry(Entity).State = EntityState.Modified;
            db.SaveChanges();
        }
        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return db.Set<T>().ToList();
               
            }
            else
            {
                return db.Set<T>().Where(filter).ToList();
            }
        }

        public T GetByID(Expression<Func<T, bool>> filter)
        {
            return db.Set<T>().SingleOrDefault(filter);
        }

    }
}
