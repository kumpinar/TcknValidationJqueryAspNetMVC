﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TcknValidationJQueryAspNetMVC.Models;

namespace TcknValidationJQueryAspNetMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Person m)
        {
            if (ModelState.IsValid)
            {
                return Json("TCKN dahil tüm parametreler doğrulandı!");
            }
            else
            {
                return Json("Yanlış olan birşeyler var!");
            }
        }
    }
}