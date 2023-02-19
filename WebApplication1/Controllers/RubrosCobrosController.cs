﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.Entity;


namespace WebApplication1.Controllers
{
    public class RubrosCobrosController : Controller
    {
        // GET: RubrosCobros
        public ActionResult Index()
        {
            List<PLAN_COBRO> list = null;
            try
            {
                using (CONDOMINIOSEntities ctx = new CONDOMINIOSEntities())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    list = ctx.PLAN_COBRO.Include(x => x.RUBRO_COBRO).ToList();
                }
            }
            catch
            {
                throw;
            }
            return View(list);
        }
    }
}