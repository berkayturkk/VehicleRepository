using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRepository.DAL.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        List<T> GetList();
        T GetById(int id);
        T Update(T t);
        void Delete(T t);
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
