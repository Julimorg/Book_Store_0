using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Project_Web_1.Models
{
    public class BooksController : Controller
    {
        // GET: Book
        private List<Books> list;
        public BooksController()
        {
            list = new List<Books>();
            //Book1
            list.Add(new Books()
            {
                ID = 1,
                Title = "Death in the Clan",
                Author = "Carley Reid",
                PublishYear = 2023,
                Price = 2.5,
                Cover = ""

            });
            //Book2
            list.Add(new Books()
            {
                ID = 2,
                Title = "God Father ",
                Author = "Mario Pluzo",
                PublishYear = 1990,
                Price = 20,
                Cover = ""

            });
            //Book3
            list.Add(new Books()
            {
                ID = 1,
                Title = "Death in the Clan2",
                Author = "Carley Reid",
                PublishYear = 2011,
                Price = 14.5,
                Cover = ""

            });
        }
        public ActionResult Index() 
        { 
            ViewBag.TitlePageName = "Hutech Libray";
            return View(list);
        }
    }
}