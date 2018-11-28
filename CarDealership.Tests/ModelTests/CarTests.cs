using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarDealership.Models;
using System;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTest
  {

    [TestMethod]
    public void CarConstructor_CreatesInstanceOfCar_Car()
    {
      //Arrange
      Car testCar = new Car("2014 Porsche 911", 114991, 7864, "color of the car is red, with leather seats.");

      //Act and Assert
      Assert.AreEqual(typeof(Car), testCar.GetType());
    }

    [TestMethod]
    public void GetMakeModel_ReturnsMakeModel_MakeModel()
    {
      //Arrange
      string inputModel = "Camry";
      Car testCar = new Car(inputModel, 114991, 7864, "color of the car is red, with leather seats." );

      //Act
      string result = testCar.GetMakeModel();

      //Assert
      Assert.AreEqual("Camry", result);
    }

    [TestMethod]
    public void SetMakeModel_UpdateMakeModel_UpdatedMakeModel()
    {
      //Arrange
      string inputModel = "Camry";
      Car testCar = new Car(inputModel, 114991, 7864, "color of the car is red, with leather seats.");

      //Act
      string updateInputModel = "Accord";
      testCar.SetMakeModel(updateInputModel);
      string resultModel = testCar.GetMakeModel();

      //Assert
      Assert.AreEqual("Accord", resultModel);
    }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_CarList()
    // {
    //   // Arrange
    //   List<Car> newList = new List<Car> {};
    //
    //   // Act
    //   List<Car> result = Car.GetAll();
    //   foreach (Car car in result)
    //   {
    //     Console.WriteLine("Output from empty list GetAll test: " + this.GetMakeModel());
    //   }
    //
    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
    //
    // [TestMethod]
    // public void GetAll_ReturnsCars_CarList()
    // {
    //   //Arrange
    //   string inputModel01 = "Camry";
    //   string inputModel02 = "Accord";
    //   int inputPrice01 = 50000;
    //   int inputPrice02 = 100000;
    //   int inputMiles01 = 90000;
    //   int inputMiles02 = 100000;
    //   string inputNote01 = "white color with leather interior";
    //   string inputNote02 = "black color";
    //   Car newCar1 = new Car(inputModel01, inputPrice01, inputMiles01, inputNote01);
    //   Car newCar2 = new Car(inputModel02, inputPrice02, inputMiles02, inputNote02);
    //   List<Car> newCarList = new List<Car> { newCar1, newCar2 };
    //
    //   //Act
    //   List<Car> resultCarList = Car.GetAll();
    //
    //   foreach (Car car in result)
    //   {
    //     Console.WriteLine("Output from second GetAll test: " + thisCar.GetDescription());
    //   }
    //
    //   //Assert
    //   CollectionAssert.AreEqual(newCarList, resultCarList);
    // }

    [TestMethod]
    public void WorthBuying_ReturnsTrueOrFalseForEnteredSpecs_List()
    {
      // Arrange
      string inputModel01 = "Camry";
      string inputModel02 = "Accord";
      int inputPrice01 = 50000;
      int inputPrice02 = 100000;
      int inputMiles01 = 90000;
      int inputMiles02 = 100000;
      string inputNote01 = "white color with leather interior";
      string inputNote02 = "black color";
      Car newCar1 = new Car(inputModel01, inputPrice01, inputMiles01, inputNote01);
      Car newCar2 = new Car(inputModel02, inputPrice02, inputMiles02, inputNote02);
      List<Car> newCarList = new List<Car> {newCar1, newCar2};

      // Act
      int maxPrice = 60000;
      int maxMiles = 95000;
      List<Car> CarsMatchingSearch = new List<Car>{};

      foreach (Car automobile in newCarList)
      {
        if (automobile.WorthBuying(maxPrice, maxMiles))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      if(CarsMatchingSearch.Count == 0)
      {
        Console.WriteLine("There is no cars matching you criteria.");
      }
      Car resultCar = new Car(inputModel01, inputPrice01, inputMiles01, inputNote01);
      List<Car> resultCarList = new List<Car> {resultCar};

      // Assert
      CollectionAssert.AreEqual(CarsMatchingSearch, resultCarList);
    }


  }
}
