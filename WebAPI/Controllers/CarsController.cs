using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet, Route("getAll")]
        public IActionResult GetAll()
        {
            var result = _carService.GetCarDetails();
            return Ok(result);
        }

        [HttpGet, Route("getById")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            return Ok(result);
        }


        [HttpGet, Route("getCarsByBrandId")]
        public IActionResult GetCarsByBrandId(int id)
        {
            return Ok(_carService.GetCarsByBrandId(id));
        }

        [HttpGet, Route("getCarsByColorId")]
        public IActionResult GetCarsByColorId(int id)
        {
            return Ok(_carService.GetCarsByColorId(id));
        }


        [HttpPost, Route("add")]
        public IActionResult Add(Car car)
        {
            return Ok(_carService.Add(car));
        }

        [HttpPut, Route("uptade")]
        public IActionResult Uptade([FromBody] Car car)
        {
            return Ok(_carService.Uptade(car));
        }

        [HttpDelete, Route("delete")]
        public IActionResult Delete([FromBody] Car car)
        {
            return Ok(_carService.Delete(car));
        }
    }
}
