using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VehicleRepository.API.Dtos;
using VehicleRepository.BL.Concrete;
using VehicleRepository.DAL.EntityFramework;

namespace VehicleRepository.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IMapper _mapper;
        CarManager _carManager = new CarManager(new EFCarRepository());

        public CarController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult GetListWithColorAndUser()
        {
            var cars = _carManager.GetListWithColorAndUser();
            List<CarDto> _carDto = _mapper.Map<List<CarDto>>(cars);
            return Ok(_carDto);
        }


        [HttpGet("{color}")]
        public IActionResult GetListCarsByColor(string color)
        {
            if (color != null)
            {
                var cars = _carManager.GetListAllByColor(color);
                List<CarDto> _carDto = _mapper.Map<List<CarDto>>(cars);
                return Ok(_carDto);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult OnHeadLights(int id)
        {
            var _car = _carManager.GetById(id);
            var cars = _carManager.GetListWithColorAndUser();
            List<CarDto> _carDto = _mapper.Map<List<CarDto>>(cars);

            if (_car == null)
            {
                return BadRequest();
            }
            else
            {
                if (_car.OnHeadlights == false)
                {
                    _car.OnHeadlights = true;
                    var newCar = _carManager.Update(_car);
                    return Ok(_carDto);
                }
                else
                {
                    _car.OnHeadlights = false;
                    var newCar = _carManager.Update(_car);
                    return Ok(_carDto);
                }
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int id)
        {
            var deleteCar = _carManager.GetById(id);
            _carManager.Delete(deleteCar);
            return Ok();
        }
    }
}
