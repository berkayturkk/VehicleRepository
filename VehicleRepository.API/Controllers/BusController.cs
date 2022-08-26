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
    public class BusController : ControllerBase
    {
        private readonly IMapper _mapper;
        BusManager _busManager = new BusManager(new EFBusRepository());

        public BusController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult GetListWithColorAndUser()
        {
            var bus = _busManager.GetListWithColorAndUser();
            List<BusDto> _busDtos = _mapper.Map<List<BusDto>>(bus);
            return Ok(_busDtos);
        }

        [HttpGet("{color}")]
        public IActionResult GetListBusesByColor(string color)
        {
            if (color != null)
            {
                var bus = _busManager.GetListAllByColor(color);
                List<BusDto> _busDtos = _mapper.Map<List<BusDto>>(bus);
                return Ok(_busDtos);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult OnHeadLights(int id)
        {
            var _bus = _busManager.GetById(id);
            var bus = _busManager.GetListWithColorAndUser();
            List<BusDto> _busDto = _mapper.Map<List<BusDto>>(bus);

            if (_bus == null)
            {
                return BadRequest();
            }
            else
            {
                if (_bus.OnHeadlights == false)
                {
                    _bus.OnHeadlights = true;
                    var newBus = _busManager.Update(_bus);
                    return Ok(_busDto);
                }
                else
                {
                    _bus.OnHeadlights = false;
                    var newBus = _busManager.Update(_bus);
                    return Ok(_busDto);
                }
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBus(int id)
        {
            var deleteBus = _busManager.GetById(id);
            _busManager.Delete(deleteBus);
            return Ok();
        }
    }
}
