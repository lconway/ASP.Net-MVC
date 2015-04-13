using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NerdDinner.Models;

namespace NerdDinner.Controllers
{
    public class DinnersController : Controller
    {
        DinnerRepository dinnerRepository = new DinnerRepository();
        //
        // HTTP-GET: /Dinners/

        public ActionResult Index() {
            var dinners = dinnerRepository.FindUpcomingDinners().ToList();

            return View("Index", dinners);
        }

        //
        // HTTP-GET: /Dinners/Details/2

        public ActionResult Details(int id) {
            Dinner dinner = dinnerRepository.GetDinner(2);
            if (dinner == null)
                return View("NotFound");
            else
                return View("Details", dinner);
        }
    }
}
