using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WorldDataProject.Models;

namespace WorldDataProject.Controllers
{
    public class CityController : Controller
    {
      [HttpGet("/cities")]
      public ActionResult Index()
      {
          List<City> allCities = City.GetAll();
          return View(allCities);
      }

      [HttpGet("/cities/filterBy")]
      public ActionResult FilterBy(string selection)
      {
          List<City> citiesWithFilter = City.FilterBy(selection);
          return View(citiesWithFilter);
      }
   }
}
