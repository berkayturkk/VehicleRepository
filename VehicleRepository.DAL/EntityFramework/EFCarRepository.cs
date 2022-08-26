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
    public class EFCarRepository : GenericRepository<Car>, ICarDAL
    {
        public List<Car> GetListByColor(string color)
        {
            using (var _sqlDbContext = new sqlDbContext())
            {
                return _sqlDbContext.Cars.Include(x => x.Color).Include(y => y.CarUser).Where(x => x.Color.ColorName == color).ToList();
            }
        }

        public List<Car> GetListWithColorAndUser()
        {
            using (var _sqlDbContext = new sqlDbContext())
            {
                return _sqlDbContext.Cars.Include(x => x.Color).Include(y => y.CarUser).ToList();
            }
        }
    }
}
