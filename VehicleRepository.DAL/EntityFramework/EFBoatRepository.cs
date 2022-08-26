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
    public class EFBoatRepository : GenericRepository<Boat>, IBoatDAL
    {
        public List<Boat> GetListByColor(string color)
        {
            using (var _sqlDbContext = new sqlDbContext())
            {
                return _sqlDbContext.Boats.Include(x => x.Color).Include(y => y.BoatUser).Where(x => x.Color.ColorName == color).ToList();
            }
        }

        public List<Boat> GetListWithColorAndUser()
        {
            using (var _sqlDbContext = new sqlDbContext())
            {
                return _sqlDbContext.Boats.Include(x => x.Color).Include(y => y.BoatUser).ToList();
            }
        }
    }
}
