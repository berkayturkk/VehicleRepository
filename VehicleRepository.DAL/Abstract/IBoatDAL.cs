using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.Entities.Concrete;

namespace VehicleRepository.DAL.Abstract
{
    public interface IBoatDAL : IGenericDAL<Boat>
    {
        List<Boat> GetListByColor(string color);
        List<Boat> GetListWithColorAndUser();
    }
}
