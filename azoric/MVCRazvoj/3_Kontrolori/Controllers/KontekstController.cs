using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _3_Kontrolori.Controllers
{
    public class KontekstController : Controller
    {
        public IActionResult Index()
        {
            DateTime datum = DateTime.Now;

            return View((object)datum);
        }
    }
}