using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using OptionsPattern.Configurations;

namespace OptionsPattern.Controllers;

public class HomeController : ControllerBase
{
    private readonly ExampleOptions _exampleOptions;
    
    public HomeController(IOptions<ExampleOptions> exampleOptions)
    {
        _exampleOptions = exampleOptions.Value;
    }
    
    public IActionResult Get()
    {
        Console.WriteLine(_exampleOptions.ExampleKey);
        Console.WriteLine(_exampleOptions.ExampleKey);
        Console.WriteLine(_exampleOptions.ExampleKey);
        
        return Ok();
    }
}