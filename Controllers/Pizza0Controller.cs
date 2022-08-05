using Microsoft.AspNetCore.Mvc;

namespace aspcotapi.Controllers;

[ApiController]
[Route("[controller]")]
public class Pizza0Controller : Controller{


private static readonly string[] Summary=new []{
"Freezing",
"Freezing1",
"Freezing2",
"Freezing3",
"Freezing4",
"Freezing5"

};
private readonly ILogger<Pizza0Controller> _logger;

public Pizza0Controller(ILogger<Pizza0Controller> logger)
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