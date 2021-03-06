﻿using CarInsuranceMVC.Models;
using CarInsuranceMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CarInsuranceMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            //instantiate entities object and passed into connection string to access to db
            using (CarInsurance1Entities db = new CarInsurance1Entities())
            {
                var users = db.Users; // access db, contains all records in db
                var getquoteVms = new List<GetQuoteVm>(); // create new list of viewmodels
                 //map the viewmodels from the model to viewmodel then pass list to view
                foreach (var user in users)
                {
                    var getquoteVm = new GetQuoteVm
                    { // map db object to view model
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        EmailAddress = user.EmailAddress,
                        EstimatedQuote = Convert.ToDouble(user.EstimatedQuote)
                    };
                    getquoteVms.Add(getquoteVm);
                }
                return View(getquoteVms);
            }
        }
    }
}