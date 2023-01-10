using LaMiaPizzeriaModel.Database;
using LaMiaPizzeriaModel.Models;
using LaMiaPizzeriaModel.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace LaMiaPizzeriaModel.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using(PizzaContext db = new PizzaContext())
            {
                List<Pizza> listPizzas = db.Pizzas.ToList<Pizza>();
                return View("Index", listPizzas);
            }
        }

        public IActionResult Details(int id)
        {
            using (PizzaContext db = new PizzaContext())
            {
                Pizza pizzaFound = db.Pizzas
                    .Where(PizzaNelDb => PizzaNelDb.Id == id)
                    .FirstOrDefault();

                if (pizzaFound != null)
                {
                    return View(pizzaFound);
                }


                return NotFound("La pizza non esiste!");
            }
                
            
        }

    }
}
