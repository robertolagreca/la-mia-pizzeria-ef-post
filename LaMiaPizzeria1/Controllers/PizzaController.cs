using LaMiaPizzeriaModel.Database;
using LaMiaPizzeriaModel.Models;
using LaMiaPizzeriaModel.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Client;

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

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza formData)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", formData);
            }

            using (PizzaContext db = new PizzaContext())
            {
                db.Pizzas.Add(formData);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
