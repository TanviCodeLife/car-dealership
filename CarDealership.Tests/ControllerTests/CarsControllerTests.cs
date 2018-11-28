using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Controllers;
using CarDealership.Models;
using System;

namespace CarDealership.Tests
{
    [TestClass]
    public class CarsControllerTest
    {
      [TestMethod]
    public void Index_HasCorrectModelType_CarList()
    {
        //Arrange
        CarsController controller = new CarsController();
        ViewResult indexView = controller.Index() as ViewResult;

        //Act
        var result = indexView.ViewData.Model;

        //Assert
        Assert.IsInstanceOfType(result, typeof(List<Car>));

    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
        //Arrange
        CarsController controller = new CarsController();

        //Act
        ActionResult view = controller.Create("Camry", 10000, 60000, "silver sedan");

        //Assert
        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
        //Arrange
        CarsController controller = new CarsController();
        RedirectToActionResult actionResult = controller.Create("Camry", 10000, 60000, "silver sedan") as RedirectToActionResult;

        //Act
        string result = actionResult.ActionName;

        //Assert
        Assert.AreEqual(result, "Index");
    }
  }
}
