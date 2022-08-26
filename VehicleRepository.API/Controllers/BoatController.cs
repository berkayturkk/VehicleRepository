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
    public class BoatController : ControllerBase
    {
        private readonly IMapper _mapper;
        BoatManager _boatManager = new BoatManager(new EFBoatRepository());

        public BoatController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult GetListWithColorAndUser()
        {
            var boat = _boatManager.GetListWithColorAndUser();
            List<BoatDto> _boatDtos = _mapper.Map<List<BoatDto>>(boat);
            return Ok(_boatDtos);
        }

        [HttpGet("{color}")]
        public IActionResult GetListBoatsByColor(string color)
        {
            if (color != null)
            {
                var boat = _boatManager.GetListAllByColor(color);
                List<BoatDto> _boatDtos = _mapper.Map<List<BoatDto>>(boat);
                return Ok(_boatDtos);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult OnHeadLights(int id)
        {
            var _boat = _boatManager.GetById(id);
            var boat = _boatManager.GetListWithColorAndUser();
            List<BoatDto> _boatDto = _mapper.Map<List<BoatDto>>(boat);

            if (_boat == null)
            {
                return BadRequest();
            }
            else
            {
                if (_boat.OnHeadlights == false)
                {
                    _boat.OnHeadlights = true;
                    var newBoat = _boatManager.Update(_boat);
                    return Ok(_boatDto);
                }
                else
                {
                    _boat.OnHeadlights = false;
                    var newBoat = _boatManager.Update(_boat);
                    return Ok(_boatDto);
                }
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBoat(int id)
        {
            var deleteBoat = _boatManager.GetById(id);
            _boatManager.Delete(deleteBoat);
            return Ok();
        }
    }
}
