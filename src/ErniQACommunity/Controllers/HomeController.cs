using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ErniQACommunity.Controllers
{
    /// <summary>
    /// HomeController class
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class HomeController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Errors this instance.
        /// </summary>
        /// <returns></returns>
        public IActionResult Error()
        {
            return View();
        }
    }
}
