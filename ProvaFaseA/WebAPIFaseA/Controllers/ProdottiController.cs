using Microsoft.AspNetCore.Mvc;
using WebAPIFaseA.DTO;
using WebAPIFaseA.Entities;
using WebAPIFaseA.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIFaseA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdottiController : ControllerBase
    {
        private IProdottiService _service;
        public ProdottiController(IProdottiService service)
            => _service = service;
        // GET: api/<ProdottiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProdottiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProdottiController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Prodotto p)
        {
            await _service.AddProdotto(p);
            return Ok();
        }

        // PUT api/<ProdottiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProdottiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
