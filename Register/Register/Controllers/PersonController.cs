using Microsoft.AspNetCore.Mvc;
using Register.Model;
using Register.Services.Implementation;

namespace Register.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        private IPerson personService;
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger, IPerson personService)
        {
            _logger = logger;
            this.personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(personService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            Person retrievedPerson = personService.Get(id);
            if(retrievedPerson == null) { return NotFound(); }
            return Ok(retrievedPerson);
        }

        [HttpPost]
        public IActionResult CreatePerson([FromBody]Person person)
        {
            if(person == null) return BadRequest();
            return Ok(personService.Create(person));
        }

        [HttpPut]
        public IActionResult UpdatePerson([FromBody]Person person)
        {
            if (person == null) return BadRequest();
            Person retrievedPerson = personService.Get(person.Id);
            if(retrievedPerson == null) return NotFound();
            else
            {
                return Ok(personService.Update(person));
            }
        }

        [HttpDelete]
        public IActionResult DeletePerson(string id) {
            if(personService.Delete(id)) return NoContent();

            return Ok("Usuário Deletado");
        }
    }
}