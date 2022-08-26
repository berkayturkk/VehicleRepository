using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRepository.BL.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> GetListAll();
        T GetById(int id);
        T Update(T t);
        void Delete(T t);
        List<T> GetListAllByFilter(Expression<Func<T, bool>> filter);
    }
}
