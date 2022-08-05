using Microsoft.AspNetCore.Mvc;
using aspcotapi.Services;
namespace aspcotapi.Controllers;


[ApiController]
[Route("[controller]")]
public class PizzaController : Controller{


 
public PizzaController()
{
    
}

//get all actions
    [HttpGet(Name = "GetPizzaAll")]
public ActionResult<List<Pizza>> GetAll()=>PizzaService.GetAll();



//get by id action

[HttpGet("{id}")]
public ActionResult<Pizza> Get(int id){
    var pizza=PizzaService.Get(id);
if(pizza==null){
    return NotFound();
}
    return pizza;
}
//post action


[HttpPost]
public IActionResult Create(Pizza pizza){
    PizzaService.Add(pizza);
    return CreatedAtAction(nameof(Create), new {id=pizza.id}, pizza);
}




//put action

[HttpPut]
public IActionResult Update(int id, Pizza pizza){
    if(id!=pizza.id){
        return BadRequest();
    }

    var existingpiza=PizzaService.Get(id);

    if(existingpiza==null){
        return NotFound();
    }

    PizzaService.update(pizza);

    return NoContent();
}


[HttpDelete("{id}")]
public IActionResult Delete(int id){
    var pizza=PizzaService.Get(id);
    if(pizza is null)
    return NotFound();
    PizzaService.Delete(id);
return NoContent();
}

//delete action

}