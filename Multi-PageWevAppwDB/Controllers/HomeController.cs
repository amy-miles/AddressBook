using Microsoft.AspNetCore.Mvc;
using Multi_PageWevAppwDB.Models;
using System.Diagnostics;

namespace Multi_PageWevAppwDB.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx) => context = ctx;

        public IActionResult Index()
        {

            var contact = context?.Contacts?.OrderBy(c => c.Name).ToList();

            return View(contact);
        }

       
       
    }
}