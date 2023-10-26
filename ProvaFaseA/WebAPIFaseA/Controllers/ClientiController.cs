using Microsoft.AspNetCore.Mvc;
using WebAPIFaseA.DataSource;
using WebAPIFaseA.DTO;
using WebAPIFaseA.Entities;
using WebAPIFaseA.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIFaseA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientiController : ControllerBase
    {
        private IClientiService _service;
        public ClientiController(IClientiService service)
            => _service = service;
        // GET: api/<ClientiController>
        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> Get()
        {
            return await _service.GetClienti();
        }

        // GET api/<ClientiController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RestituisciClienteDto>> Get(int id)
        {
            return await _service.GetCliente(id);
        }

        // POST api/<ClientiController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Cliente c)
        {
            DateTime dataOggi = DateTime.Now;
            int maggiorenne = dataOggi.Year - c.DataDiNascita.Year;
            if(maggiorenne < 18) return BadRequest("I clienti devono essere maggiorenni");
            if (c.Passward.Count() < 18) return BadRequest("La password deve essere composta da almeno 12 caratteri");
            await _service.AddCliente(c);
            return Ok();
        }

        // PUT api/<ClientiController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ModificaPasswardDto p)
        {
            await _service.UpdatePassward(id, p);
            return Ok();
        }

        // DELETE api/<ClientiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
