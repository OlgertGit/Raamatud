using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Мы добавляем контроллер.
namespace MvcMovie.Controllers
{
public class HelloWorldController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
        // Данный код для приветствие - Tere! (Один раз)
    public ActionResult Welcome(string name, int numTimes = 1)
    {
        ViewBag.Message = "Tere! " + name;
        ViewBag.NumTimes = numTimes;

        return View();
    }
}
}