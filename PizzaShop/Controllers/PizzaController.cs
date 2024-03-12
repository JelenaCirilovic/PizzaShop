using Microsoft.AspNetCore.Mvc;
using PizzaShop.Models;

namespace PizzaShop.Controllers
{
    public class PizzaController : Controller
    {
        private IPieRepository _pieRepository;

        public PizzaController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            ViewBag.uslov = false;
            ViewBag.Message = "Ovo je poruka sa servera";
            ViewBag.Mesage2 = "Ovo je druga poruka";

            return View();
        }

        public ViewResult List()
        {
            var vm = _pieRepository.Pies;

            return View(vm);
        }
    }
}
