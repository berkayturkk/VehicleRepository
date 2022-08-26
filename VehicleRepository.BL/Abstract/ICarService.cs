using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.Entities.Concrete;

namespace VehicleRepository.BL.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        List<Car> GetListAllByColor(string color);
        List<Car> GetListWithColorAndUser();
    }
}
