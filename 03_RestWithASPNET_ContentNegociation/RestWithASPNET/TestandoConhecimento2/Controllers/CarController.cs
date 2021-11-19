using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestandoConhecimento2.Business.Interfaces;
using TestandoConhecimento2.Model.Entities;

namespace TestandoConhecimento2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarBusiness _carBusiness;

        public CarController(ICarBusiness carBusiness, ILogger<CarController> logger)
        {
            _carBusiness = carBusiness;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_carBusiness.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_carBusiness.GetById(id));

        [HttpPost]
        public IActionResult Create([FromBody] Car item)
        {
            if (item == null) return BadRequest();
            return Ok(_carBusiness.Create(item));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Car item)
        {
            if (item == null) return BadRequest();
            return Ok(_carBusiness.Update(item));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _carBusiness.Delete(id);
            return NoContent();
        }
    }
}
