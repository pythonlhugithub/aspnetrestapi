using Microsoft.AspNetCore.Mvc;

namespace aspcotapi.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : Controller{


private static readonly string[] Summary=new []{
"Freezing",
"Freezing1",
"Freezing2",
"Freezing3",
"Freezing4",
"Freezing5"

};
private readonly ILogger<PizzaController> _logger;

public PizzaController(ILogger<PizzaController> logger)
{
    _logger=logger;
}

[HttpGet("GetPizza")]
public IEnumerable<Pizza> Get(){

return Enumerable.Range(1,5).Select(i=>new Pizza{
    PizzaName=Summary[Random.Shared.Next(Summary.Length)]
}).ToArray();
}




}