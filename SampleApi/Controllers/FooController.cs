using Microsoft.AspNetCore.Mvc;
using SampleApi.Models;

namespace SampleApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FooController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var result = new Foo
        {
            Id = id, 
            Description = $"This is foo {id}."
        };

        return Ok(result);
    }
}