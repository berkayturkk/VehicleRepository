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
    public class BoatManager : IBoatService
    {
        private readonly IBoatDAL _boatDAL;

        public BoatManager(IBoatDAL boatDAL)
        {
            _boatDAL = boatDAL;
        }

        public void Delete(Boat t)
        {
            _boatDAL.Delete(t);
        }

        public Boat GetById(int id)
        {
            if (id > 0)
            {
                return _boatDAL.GetById(id);
            }

            throw new Exception("ID 1'den küçük olamaz !");
        }

        public List<Boat> GetListAll()
        {
            return _boatDAL.GetList();
        }

        public List<Boat> GetListAllByFilter(Expression<Func<Boat, bool>> filter)
        {
            return _boatDAL.GetListByFilter(filter);
        }

        public Boat Update(Boat t)
        {
            return _boatDAL.Update(t);
        }
        public List<Boat> GetListAllByColor(string color)
        {
            return _boatDAL.GetListByColor(color);
        }

        public List<Boat> GetListWithColorAndUser()
        {
            return _boatDAL.GetListWithColorAndUser();
        }
    }
}
