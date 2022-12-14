using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService= carService;
        }
        [HttpGet("getall")] 
        public IActionResult GetAll()
        {
            var result=_carService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Messages);
            }
        }

        [HttpGet("getbyid")] 
        public IActionResult GetById(int id)
        {
            var result=_carService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Messages);
            }
        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result=_carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
