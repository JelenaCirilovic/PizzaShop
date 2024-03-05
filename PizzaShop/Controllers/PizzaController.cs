using Microsoft.AspNetCore.Mvc;
using PizzaShop.Models;

namespace PizzaShop.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.uslov = false;
            ViewBag.Message = "Ovo je poruka sa servera";
            ViewBag.Mesage2 = "Ovo je druga poruka";
            return View();
            
        }
        private IPieRepository _repository;

        public PizzaController(IPieRepository repository) 
        { 
            _repository=repository;
        }


        public ViewResult List()
        {
            return View(_repository.Pies);
        }
    }

}
