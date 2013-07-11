﻿using GiveIT.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace GiveIT.UI.Web.Controllers
{
    public class VolunteerController : Controller
    {
        //
        // GET: /Volunteer/

        UIWebDbContext db = new UIWebDbContext();


        [AllowAnonymous]
        public ActionResult RegisterVolunteer()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterVolunteer(VolunteerRegister model)
        {

            if (ModelState.IsValid)
            {
                WebSecurity.CreateUserAndAccount(model.UserName, model.Password,
                    propertyValues: new
                    {
                        ContactFirstName = model.ContactFirstName,
                        ContactLastName = model.ContactLastName,
                        VolunteerHours = model.VolunteerHours,
                        PhoneNumber = model.PhoneNumber,
                        PhoneNoExtension = model.PhoneNoExtension,
                        EmailAddress = model.EmailAddress
                    });

            }
            return View(model);
        }
    }
}