using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.DAL.Abstract;
using VehicleRepository.DAL.Context;

namespace VehicleRepository.DAL.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public void Delete(T t)
        {
            using(var _sqlDbContext = new sqlDbContext())
            {
                _sqlDbContext.Set<T>().Remove(t);
                _sqlDbContext.SaveChanges();
            }
        }

        public T GetById(int id)
        {
            using (var _sqlDbContext = new sqlDbContext())
            {
                return _sqlDbContext.Set<T>().Find(id);
            }
        }

        public List<T> GetList()
        {
            using (var _sqlDbContext = new sqlDbContext())
            {
                return _sqlDbContext.Set<T>().ToList();
            }
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using (var _sqlDbContext = new sqlDbContext())
            {
                return _sqlDbContext.Set<T>().Where(filter).ToList();
            }
        }

        public T Update(T t)
        {
            using (var _sqlDbContext = new sqlDbContext())
            {
                _sqlDbContext.Set<T>().Update(t);
                _sqlDbContext.SaveChanges();
                return t;
            }
        }
    }
}
