using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles, string note)
    {
      Car myCar = new Car(makeModel, price, miles, note);
      return RedirectToAction("Index");
    }

    [HttpPost("/cars/delete")]
    public ActionResult DeleteAll()
    {
      Car.ClearAll();
      return View();
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Car car = Car.Find(id);
      return View(car);
    }

  }
}
