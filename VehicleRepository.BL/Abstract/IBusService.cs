using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.Entities.Concrete;

namespace VehicleRepository.BL.Abstract
{
    public interface IBusService : IGenericService<Bus>
    {
        List<Bus> GetListAllByColor(string color);
        List<Bus> GetListWithColorAndUser();
    }
}
