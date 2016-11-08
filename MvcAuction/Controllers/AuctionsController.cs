using System;
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
                Description = "This is 1st Auction",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurrentPrice = null
                },
                new Models.Auction()
                {
                Title = "Example Auction #2",
                Description = "This is 2nd Auction",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurrentPrice = null
                },
                new Models.Auction()
                {
                Title = "Example Auction #3",
                Description = "This is 3rd Auction",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurrentPrice = 30m
                }
            };
            return View(auctions);
        }
        public ActionResult TempDataDemo()
        {
            TempData["SuccessMessage"] = "The action succeeded!";
            return RedirectToAction("Index");
        }
        public ActionResult Auction()
        {
            var auction = new MvcAuction.Models.Auction()
            {
                Title = "Example Auction",
                Description = "This is an Example Auction",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurrentPrice = null
            };

            return View(auction);
        }

        public ActionResult Create()
        {
            var categoryList = new SelectList(new[] { "Automotive", "Electronics", "Games", "Home" });
            ViewBag.CategoryList = categoryList;
            return View();
        }

    }
}
