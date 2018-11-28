using System;
using System.Collections.Generic;

namespace CarDealership.Models {

  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _note;
    private static List<Car> _instances = new List<Car> {};

    public Car(string makeModel, int price, int miles, string note)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _note = note;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }

    public string GetNote()
    {
      return _note;
    }

    public void SetNote(string newNote)
    {
      _note = newNote;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (_price < maxPrice && _miles < maxMiles);
    }
  }
}
