﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPC_Rental.Models;

namespace PPC_Rental.Controllers
{

    public class DetailsController : Controller
    {
        DemoPPCRentalEntities db = new DemoPPCRentalEntities();
        public ActionResult Details(int id)
        {
            var property = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(property);
        }
    }
}
