using Microsoft.AspNetCore.Mvc;
using WebAPIFaseA.Entities;
using WebAPIFaseA.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIFaseA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrelloController : ControllerBase
    {
        private ICarrelloService _service;
        public CarrelloController(ICarrelloService service)
            => _service = service;
        // GET: api/<CarrelloController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CarrelloController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Carrello>>> Get(int id)
        {
            return await _service.GetCarrello(id);
        }

        // POST api/<CarrelloController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Carrello carrello)
        {
            await _service.AddCarrrello(carrello);
            return Ok();
        }

        // PUT api/<CarrelloController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id)
        {
            await _service.UpdateProdotto(id);
            return Ok();
        }

        // DELETE api/<CarrelloController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
