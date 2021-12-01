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
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet, Route("getAll")]
        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();
            return Ok(result);
        }

        [HttpGet, Route("getById")]
        public IActionResult GetById(int id)
        {
            return Ok(_colorService.GetById(id));
        }


        [HttpPost, Route("add")]
        public IActionResult Add(Color color)
        {
            return Ok(_colorService.Add(color));
        }

        [HttpPut, Route("uptade")]
        public IActionResult Uptade([FromBody] Color color)
        {
            return Ok(_colorService.Uptade(color));
        }

        [HttpDelete, Route("delete")]
        public IActionResult Delete([FromBody] Color color)
        {
            return Ok(_colorService.Delete(color));
        }
    }
}
