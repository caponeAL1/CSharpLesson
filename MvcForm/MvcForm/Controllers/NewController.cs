﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MvcForm.Controllers
{
    public class NewController : Controller
    {
        // GET: NewController
        public ActionResult Start()
        {
            return View();
        }
    }
}
