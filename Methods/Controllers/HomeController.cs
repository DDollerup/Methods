using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Methods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Hine
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(string text)
        {
            string polishedText = string.Empty;
            RemoveSpaces(text, out polishedText);



            ViewBag.Result = polishedText;
            return View("Index");
        }

        public int AddNumbers(int x, int y)
        {
            return x + y;
        }

        public void RemoveSpaces(string text, out string result)
        {
            string textWithoutSpaces = text.Replace(" ", "");

            // Gør alle bugstaverne til store bugstaver
            // result = textWithoutSpaces.ToUpper();

            // Gør alle bugstaverne til små bugstaver
            // result = textWithoutSpaces.ToLower();

             result = textWithoutSpaces;
        }
    }
}