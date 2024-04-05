using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controlers;

[ApiController]
[Route("/animals")]
public class AnimalsControler : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();
    }
}