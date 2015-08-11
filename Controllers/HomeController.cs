using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataProxy.Models;
using Microsoft.AspNet.Mvc;

namespace DataProxy.Controllers
{
    public class HomeController : Controller
    {
        [FromServices]
        public ApplicationDbContext DbContext { get; set; }
        public IActionResult Index()
        {
            //More information!
            var requests = new  SiteData(DbContext.Requests.OrderBy(p => p.TimeStamp).ToArray());
            return View(requests);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
