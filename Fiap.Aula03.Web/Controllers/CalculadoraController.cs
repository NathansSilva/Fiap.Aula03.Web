using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula03.Web.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calculadora()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculadora(int number, int number2)
        {
            
            ViewBag.abobora = number + number2;
            return View("Resultado");
        }
    }
}
