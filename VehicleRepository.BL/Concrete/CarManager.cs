using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.BL.Abstract;
using VehicleRepository.DAL.Abstract;
using VehicleRepository.Entities.Concrete;

namespace VehicleRepository.BL.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDAL _carDAL;

        public CarManager(ICarDAL carDAL)
        {
            _carDAL = carDAL;
        }

        public void Delete(Car t)
        {
            _carDAL.Delete(t);
        }

        public Car GetById(int id)
        {
            if (id > 0)
            {
                return _carDAL.GetById(id);
            }

            throw new Exception("ID 1'den küçük olamaz !");
        }

        public List<Car> GetListAll()
        {
            return _carDAL.GetList();
        }

        public List<Car> GetListAllByFilter(Expression<Func<Car, bool>> filter)
        {
            return _carDAL.GetListByFilter(filter);
        }

        public Car Update(Car t)
        {
            return _carDAL.Update(t);
        }

        public List<Car> GetListAllByColor(string color)
        {
            return _carDAL.GetListByColor(color);
        }

        public List<Car> GetListWithColorAndUser()
        {
            return _carDAL.GetListWithColorAndUser();
        }
    }
}
