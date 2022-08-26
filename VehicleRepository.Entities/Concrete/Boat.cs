using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.Entities.Abstract;

namespace VehicleRepository.Entities.Concrete
{
    public class Boat : Vehicle
    {
        [Key]
        public int BoatID { get; set; }
        public int UserID { get; set; }
        public User BoatUser { get; set; }
    }
}
