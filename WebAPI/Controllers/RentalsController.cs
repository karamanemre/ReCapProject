using Business.Abstract;
using Core.Utilities.DataResults;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalSevice;
        public RentalsController(IRentalService rentalSevice)
        {
            _rentalSevice = rentalSevice;
        }

        [HttpGet,Route("getAll")]
        public IActionResult GetAll()
        {
            var result = _rentalSevice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet,Route("getById")]
        public IActionResult GetById(int id)
        {
           
            return Ok(_rentalSevice.GetById(id));
        }

        [HttpPost, Route("deliverVehicle")]
        public IResult DeliverVehicle([FromBody] Rental rental)
        {
            return _rentalSevice.DeliverVehicle(rental);
        }

        [HttpPost, Route("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalSevice.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut, Route("uptade")]
        public IResult Uptade([FromBody] Rental rental)
        {
            return _rentalSevice.Uptade(rental);
        }

        [HttpDelete, Route("delete")]
        public IResult Delete([FromBody] Rental rental)
        {
            return _rentalSevice.Delete(rental);
        }
    }
}
