﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepository.Entities.Concrete;

namespace VehicleRepository.DAL.Abstract
{
    public interface ICarDAL : IGenericDAL<Car>
    {
        List<Car> GetListByColor(string color);
        List<Car> GetListWithColorAndUser();
    }
}
