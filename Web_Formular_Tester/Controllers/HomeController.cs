using Microsoft.AspNetCore.Mvc;
using Web_Formular_Tester.Models;

namespace Web_Formular_Tester.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Formular1()
        {
            Formular1Model model = new Formular1Model();            
            return View(model);
        }

        [HttpPost]
        public IActionResult Formular1(Formular1Model model)
        {
            return RedirectToAction("Ausgabe1", model);
        }

        public IActionResult Ausgabe1(Formular1Model model)
        {
			return View(model);
		}

        [HttpGet]
        public IActionResult Formular2()
        {
            Formular2Model model = new Formular2Model();
            model.Artikelbezeichnung = "Artikel 1";
            model.ImBestandSeit = System.DateTime.Now;
            model.Farbe = "#FF0000";
            return View(model);
        }

        [HttpPost]
        public IActionResult Formular2(Formular2Model model)
        {
			return RedirectToAction("Ausgabe2", model);
		}

        public IActionResult Ausgabe2(Formular2Model model)
        {
            return View(model);
        }

    }
}
