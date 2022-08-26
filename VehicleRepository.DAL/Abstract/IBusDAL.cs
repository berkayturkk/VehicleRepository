using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.Entities.Concrete;

namespace VehicleRepository.DAL.Abstract
{
    public interface IBusDAL : IGenericDAL<Bus>
    {
        List<Bus> GetListByColor(string color);
        List<Bus> GetListWithColorAndUser();
    }
}
