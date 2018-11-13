using System;

namespace Dealership {

  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Note;

    public Car(string makeModel, int price, int miles, string note)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Note = note;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public string GetNote()
    {
      return Note;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (Price < maxPrice && Miles < maxMiles);
    }
  }
}
