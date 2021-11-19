using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestandoConhecimento.Business.Interfaces;
using TestandoConhecimento.Model.Entities;

namespace TestandoConhecimento.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookBusiness _bookBusiness;

        public BookController(ILogger<BookController> logger, IBookBusiness personBusiness)
        {
            _logger = logger;
            _bookBusiness = personBusiness;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_bookBusiness.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_bookBusiness.GetById(id));

        [HttpPost]
        public IActionResult Create([FromBody] Book item)
        {
            if (item == null) return BadRequest();
            return Ok(_bookBusiness.Create(item));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Book item)
        {
            if (item == null) return BadRequest();
            return Ok(_bookBusiness.Update(item));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }
    }
}
