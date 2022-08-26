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
    public class BusManager : IBusService
    {
        private readonly IBusDAL _busDAL;

        public BusManager(IBusDAL busDAL)
        {
            _busDAL = busDAL;
        }

        public void Delete(Bus t)
        {
            _busDAL.Delete(t);
        }

        public Bus GetById(int id)
        {
            if (id > 0)
            {
                return _busDAL.GetById(id);
            }

            throw new Exception("ID 1'den küçük olamaz !");
        }

        public List<Bus> GetListAll()
        {
            return _busDAL.GetList();
        }

        public List<Bus> GetListAllByFilter(Expression<Func<Bus, bool>> filter)
        {
            return _busDAL.GetListByFilter(filter);
        }

        public Bus Update(Bus t)
        {
            return _busDAL.Update(t);
        }

        public List<Bus> GetListAllByColor(string color)
        {
            return _busDAL.GetListByColor(color);
        }

        public List<Bus> GetListWithColorAndUser()
        {
            return _busDAL.GetListWithColorAndUser();
        }
    }
}
