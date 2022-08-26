using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.Entities.Concrete;

namespace VehicleRepository.BL.Abstract
{
    public interface IBoatService : IGenericService<Boat>
    {
        List<Boat> GetListAllByColor(string color);
        List<Boat> GetListWithColorAndUser();
    }
}
