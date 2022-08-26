using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.DAL.Abstract;
using VehicleRepository.DAL.Context;
using VehicleRepository.DAL.Repositories;
using VehicleRepository.Entities.Concrete;

namespace VehicleRepository.DAL.EntityFramework
{
    public class EFBusRepository : GenericRepository<Bus>, IBusDAL
    {
        public List<Bus> GetListByColor(string color)
        {
            using (var _sqlDbContext = new sqlDbContext())
            {
                return _sqlDbContext.Buses.Include(x => x.Color).Include(y => y.BusUser).Where(x => x.Color.ColorName == color).ToList();
            }
        }

        public List<Bus> GetListWithColorAndUser()
        {
            using (var _sqlDbContext = new sqlDbContext())
            {
                return _sqlDbContext.Buses.Include(x => x.Color).Include(y => y.BusUser).ToList();
            }
        }
    }
}
