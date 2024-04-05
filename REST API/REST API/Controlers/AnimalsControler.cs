using Microsoft.AspNetCore.Mvc;
using REST_API.Database;

namespace REST_API.Controlers;

[ApiController]
[Route("/animals")]
public class AnimalsControler : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok();
    }
}