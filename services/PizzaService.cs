using aspcotapi;
namespace aspcotapi.Services;
public static class PizzaService{
    static List<Pizza> Pizzas{get;set;}
    static int nextid=3;

    
   static  PizzaService()
    {
        Pizzas=new List<Pizza>
        {
            new Pizza{id=1, PizzaName="howain", isGluonfree=true},
            new Pizza{id=2, PizzaName="howain", isGluonfree=true}
        };
    
    } 



public static List<Pizza> GetAll()=>Pizzas;

public static Pizza? Get(int id)=>Pizzas.FirstOrDefault(p=>p.id==id);

public static void Add(Pizza pizza){
pizza.id=nextid++;
Pizzas.Add(pizza);
}


public static void Delete(int id){
    var pizza=Get(id);

    if(pizza==null){ return;}

    Pizzas.Remove(pizza);

}

public static void update(Pizza pizza){
    var index=Pizzas.FindIndex(p=>p.id==pizza.id);
    if(index==-1){return;}
    Pizzas[index]=pizza;

}

}