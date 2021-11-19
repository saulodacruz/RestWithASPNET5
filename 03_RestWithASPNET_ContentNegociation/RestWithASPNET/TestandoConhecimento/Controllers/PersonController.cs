using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestandoConhecimento.Business.Interfaces;
using TestandoConhecimento.Model.Entities;

namespace TestandoConhecimento.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonBusiness _personBusiness;

        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
        {
            _logger = logger;
            _personBusiness = personBusiness;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_personBusiness.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_personBusiness.GetById(id));

        [HttpPost]
        public IActionResult Create([FromBody] Person item)
        {
            if (item == null) return BadRequest();
            return Ok(_personBusiness.Create(item));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Person item)
        {
            if (item == null) return BadRequest();
            return Ok(_personBusiness.Update(item));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
