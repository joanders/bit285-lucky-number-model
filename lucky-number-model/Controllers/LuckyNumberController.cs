﻿using lucky_number_model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lucky_number_model.Controllers
{
    public class LuckyNumberController : Controller
    {
        static int _starting_balance = 4; // Initial bank balance

        [HttpGet]
        public ActionResult Spin() // runs the first time the form is loaded
        {
            //Build a default Model with some initial values 
            LuckyNumber myLuck = new LuckyNumber
            {
                Number = 6,
                Balance = _starting_balance
            };
            // TODO: Initialize the spinner fields for the ViewBag to zero
            ViewBag.A = 0;
            ViewBag.B = 0;
            ViewBag.C = 0;
            
            // Pass the Model to the View
            return View(myLuck);
        }

        [HttpPost]
        public ActionResult Spin(LuckyNumber lucky) //The Model is passed in with values from the form submission
        {
            // GAME PLAY : If a spin would cause a negative balance, send the view a "Game Over" message and reset Balance
            if (lucky.Balance <= 0)
            {
                lucky.Balance = _starting_balance;

                // Pass the Model to the View (this ends the method)
                return View(lucky);
            }

            // TODO: Charge the cost of a spin (subtract 1 from the Balance)
            lucky.Balance = lucky.Balance - 1;


            // TODO: Model Spinner class
           // var rnd = new System.Random();
            //int a= rnd.Next(0, 9), b= rnd.Next(0, 9), c= rnd.Next(0, 9);



            // TODO: Assign the ViewBag variables these local variable values
           // ViewBag.A = a;
           // ViewBag.B = b;
            //ViewBag.C = c;



            //TO DO: Model Spinner class
            //Check for a winner, update Balance and the isWinner flag
           // if (a== lucky.Number || b == lucky.Number || c == lucky.Number)
          //  {
            //    lucky.Balance += 2; move this to a smart balance property
              //  lucky.isWinner = true;
            // }

            // Pass the Model to the View
            return View(lucky);
        }

    }
}