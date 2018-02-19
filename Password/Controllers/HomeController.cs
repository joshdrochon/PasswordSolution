using PasswordProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;



namespace PasswordProject.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      int reset = Password.Reset();
      return View(reset);
    }

    [HttpPost("Password/Result")] //custom path name
    public ActionResult Result()
    {
      Password newPassword = new Password();
      int pwStrength = newPassword.PasswordChecker
      (Request.Form["input-password"]);

      return View("../Password/Result", pwStrength);
    }
  }
}


/*
ln 21 - must instantiate new Password object to have
access to its [non-static] methods
*/
