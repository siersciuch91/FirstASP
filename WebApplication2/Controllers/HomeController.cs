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
      List<Contact> list = new List<Contact> { new Contact { firstName = "Adrian", secondName = "Grzegorek", city= "Nielepice", street = "Sosnawa"},
        new Contact{firstName = "Kinga", secondName = "Kwiatkowska", city = "Charsznica", street = "Kolonia Chodów" } };

      ViewBag.Kontakty = list;  

      return View();
    }

    public ActionResult Contacts()
    {
      List<Contact> list = new List<Contact> { new Contact { firstName = "Adrian", secondName = "Grzegorek", city= "Nielepice", street = "Sosnawa"},
        new Contact{firstName = "Kinga", secondName = "Kwiatkowska", city = "Charsznica", street = "Kolonia Chodów" } };

      ViewBag.Message = "Your contacts page.";
      ViewBag.Contacts = list;

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