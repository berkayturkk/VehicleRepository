using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.Entities.Concrete;

namespace VehicleRepository.Entities.Abstract
{
    public class Vehicle : IEntity
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ColorID { get; set; }
        public Color Color { get; set; }
        public bool OnHeadlights { get; set; }
    }
}
