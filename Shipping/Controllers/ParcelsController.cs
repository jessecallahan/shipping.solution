using Microsoft.AspNetCore.Mvc;
using Shipping.Models;
using System.Collections.Generic;
using System;

namespace Shipping.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      // String allParcels = "randomn string";
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult CreateThing(string height, string width, string length)
    {
      double heightDouble = Convert.ToDouble(height);
      double widthDouble = Convert.ToDouble(width);
      double lengthDouble = Convert.ToDouble(length);
      Parcel myParcel = new Parcel(heightDouble, widthDouble, lengthDouble);
      return RedirectToAction("Index");
    }


  }
}