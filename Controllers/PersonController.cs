using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }
    [HttpGet]
    public async Task<IEnumerable<Person>> GetAll()
    {
        return await _personService.Get();
    }
}
