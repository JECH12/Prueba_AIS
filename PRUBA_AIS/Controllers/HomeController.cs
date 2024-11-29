using Microsoft.AspNetCore.Mvc;
using PRUBA_AIS.Models;
using Services.Interfaces;
using System.Diagnostics;

namespace PRUBA_AIS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IFactorial _factorial;

        public HomeController(ILogger<HomeController> logger, IFactorial factorial)
        {
            _logger = logger;

            _factorial = factorial; 
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Calculate(int number)
        {

            if (number == 0)
            {
                ViewBag.Result = "El numero ingresado no es un numero positivo.";
            }

            else 
            { 
                long factorial = _factorial.GetFactorial(number);
                ViewBag.Result = $"El factorial del numero : {number} es: {factorial}";
            }

            return View("Index");  
        }
    }
}
