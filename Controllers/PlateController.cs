using checkpoint_v2_net_ita_2.Repository;
using Microsoft.AspNetCore.Mvc;
using checkpoint_v2_net_ita_2.Repository.Entities;

namespace checkpoint_v2_net_ita_2.Controllers;

[ApiController]
[Route("[controller]")]
public class PlateController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly IPlateRepository _plateRepository;

    private readonly ILogger<PlateController> _logger;

    public PlateController(ILogger<PlateController> logger, IPlateRepository plateRepository)
    {
        _logger = logger;
        _plateRepository = plateRepository;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet("All")]
    public IActionResult GetPlates()
    {
        return Ok(_plateRepository.GetPlates());
    }

    [HttpPost("Add")]
    public IActionResult Post([FromBody]Plate plate)
    {
        _plateRepository.Add(plate);
        return NoContent();
    }

    [HttpGet("AllUnder10E")]
    public IActionResult GetPlatesUnder10E()
    {
        return Ok(_plateRepository.GetPlates());
    }

    [HttpGet("ByType")]
    public IActionResult GetByType(string type)
    {
        return Ok(_plateRepository.GetPlates());
    }
}
