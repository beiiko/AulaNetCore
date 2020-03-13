using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Components
{
    [ViewComponent(Name = "ChamadosViewComponent")]
    public class ChamadosViewComponent : ViewComponent
    {
        public int numeroDeChamados { get; set; }

        public ChamadosViewComponent()
        {
            numeroDeChamados = 47;
        }

        public IViewComponentResult Invoke()
        {
            ChamadosViewComponent componentChamados = new ChamadosViewComponent();
            return View(componentChamados);
        }
    }
}
