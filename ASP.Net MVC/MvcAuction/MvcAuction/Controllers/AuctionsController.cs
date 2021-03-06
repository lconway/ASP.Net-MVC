﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAuction.Controllers
{
    public class AuctionsController : Controller
    {
        //
        // GET: /Auctions/

        public ActionResult Index()
        {
            var auctions = new[] {
                new Models.Auction()
                {
                    Title = "Example Auction #1",
                    Description = "This is an example Auction",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(7),
                    StartPrice = 1.00m,
                    CurentPrice = null,
                },
                new Models.Auction()
                {
                    Title = "Example Auction #2",
                    Description = "This is a second Auction",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(7),
                    StartPrice = 1.00m,
                    CurentPrice = 30m,
                },
                new Models.Auction()
                {
                    Title = "Example Auction #31",
                    Description = "This is a third Auction",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(7),
                    StartPrice = 10.00m,
                    CurentPrice = 24m,
                },
            };

            return View(auctions);
        }

        public ActionResult TempDataDemo() {
            TempData["SuccessMessage"] = "The action succeeded!";

            return RedirectToAction("Index");
        }

        public ActionResult Auction(long id) {
            var auction = new MvcAuction.Models.Auction() {
                Title = "Example Auction",
                Description = "This is an example Auction",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurentPrice = null,
            };

            return View(auction);
        }

        public ActionResult Create([Bind(Exclude="CurrentPrice")]Models.Auction auction) {
            var categoryList = new SelectList(new[] { "Automotive", "Electronics", 
                                    "Games", "Home" });
            ViewBag.CategoryList = categoryList;
            return View();
        }
    }
}
