using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetByID(Expression<Func<T, bool>> filter);
    }
}
