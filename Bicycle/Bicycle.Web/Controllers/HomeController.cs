﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bike.Data.Services

namespace Bicycle.Web.Controllers
{
    public class HomeController : Controller
    {

        IBikeData db
        
        public HomeController()
        {
            db = new InMemoryBikeDate;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Bike()
        {
            return View():
        }
    }
}