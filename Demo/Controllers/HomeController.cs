using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Demo.Models;

namespace Demo.Controllers
{
    [Route("")]
    [Route("admin")]
    [Route("administradores")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("Soma/{valor1:int}/{valor2:int}")]
        public IActionResult Soma(double valor1, double valor2)
        {
            double resultado = valor1 + valor2;

            return Content(Convert.ToString(resultado));
        }

        [Route("Subtracao/{valor1:int}/{valor2:int}")]
        public IActionResult Subtracao(double valor1, double valor2)
        {
            double resultado = valor1 - valor2;
            return Content(Convert.ToString(resultado));
        }

        [Route("Divisao/{valor1:int}/{valor2:int}")]
        public IActionResult Divisao(double valor1, double valor2)
        {
            double resultado = valor1 / valor2;
            return Content(Convert.ToString(resultado));
        }

        [Route("Multiplicacao/{valor1:int}/{valor2:int}")]
        public IActionResult Multiplicacao(double valor1, double valor2)
        {
            double resultado = valor1 * valor2;
            return Content(Convert.ToString(resultado));
        }

        [Route("privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
