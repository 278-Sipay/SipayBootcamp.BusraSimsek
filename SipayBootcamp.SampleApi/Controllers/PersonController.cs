using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using SipayBootcamp.AssignmentApi.Model;

namespace SipayBootcamp.AssignmentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IValidator<Person> _validator;
        public PersonController(IValidator<Person> validator)
        {
            _validator = validator;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            var validationResult = _validator.Validate(person);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            return Ok(person);
        }
    }
}
