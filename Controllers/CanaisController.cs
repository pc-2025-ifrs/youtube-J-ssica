using Microsoft.AspNetCore.Mvc;
using trabalho.Model;
using trabalho.Repositories;

namespace WebYoutube.Controllers;

[ApiController]
[Route("api/v1/canais")]
public class CanaisController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ICanalRepository _canalRepository;


    public CanaisController(ILogger<WeatherForecastController> logger, ICanalRepository canalRepository)
    {
        _logger = logger;
        _canalRepository = canalRepository;
    }

    [HttpPost(Name = "NewCanal")]
    public IActionResult NewCanal([FromBody] newCanalDTO canal) 
    {
        _canalRepository.Save(new Canal
        {
            Nome = canal.Nome
        });
        return Ok("Canal salvo com sucesso!");
    }

    [HttpGet(Name = "GetAllCanais")]
    public ActionResult<IEnumerable<Canal>> GetAll()
    {
       return Ok(_canalRepository.GetAll());
    }
}
//não é model representa o payload
public record class newCanalDTO(string Nome);

