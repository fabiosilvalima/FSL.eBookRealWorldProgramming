﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSL.eBook.RWP.DesignPatterns.ProxyChapter
{
    public class ProxyController : Controller
    {
        public ActionResult Index(int id = 19)
        {
            var user = new User() { Age = id };
            var proxy = new CalcProxy(user);
            var result = proxy.Calculate();
            var message = proxy.Message;

            return Content($"result from Proxy: {result} of age {id}: {message}");
        }
    }
}