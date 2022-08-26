using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.Entities.Abstract;

namespace VehicleRepository.Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public List<Car> UserCars { get; set; }
        public List<Bus> UserBuses { get; set; }
        public List<Boat> UserBoats { get; set; }
    }
}
