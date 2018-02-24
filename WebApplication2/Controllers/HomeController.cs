using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      List<Kontakt> list = new List<Kontakt> { new Kontakt { imie = "Adrian", nazwisko = "Grzegorek", miasto= "Nielepice", ulica = "Sosnawa"},
        new Kontakt{imie = "Kinga", nazwisko = "Kwiatkowska", miasto = "Charsznica", ulica = "Kolonia Chodów" } };

      ViewBag.Kontakty = list;  

      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}