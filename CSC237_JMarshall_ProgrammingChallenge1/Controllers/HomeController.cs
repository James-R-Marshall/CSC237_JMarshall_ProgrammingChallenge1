using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC237_JMarshall_ProgrammingChallenge1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSC237_JMarshall_ProgrammingChallenge1.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var Contacts = context.Contacts.Include(c=>c.category).OrderBy(m => m.firstName).ToList();
            return View(Contacts);
        }
    }
}