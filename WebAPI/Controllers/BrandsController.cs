using Business.Abstract;
using Core.Utilities.Results;
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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet, Route("getAll")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            return Ok(result);
        }

        [HttpGet, Route("getById")]
        public IActionResult GetById(int id)
        {
            return Ok(_brandService.GetById(id));
        }


        [HttpPost, Route("add")]
        public IActionResult Add(Brand brand)
        {
            return Ok(_brandService.Add(brand));
        }

        [HttpPut, Route("uptade")]
        public IActionResult Uptade([FromBody] Brand brand)
        {
            return Ok(_brandService.Uptade(brand));
        }

        [HttpDelete, Route("delete")]
        public IActionResult Delete([FromBody] Brand brand)
        {
            return Ok(_brandService.Delete(brand));
        }
    }
}
