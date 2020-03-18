using Loja.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Controllers
{
    public class FornecedorController : Controller
    {
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(FornecedorViewModel fornecedor)
        {
            if (!ModelState.IsValid)
            {
                return View(fornecedor);
            }
            return View();
        }
    }
}
