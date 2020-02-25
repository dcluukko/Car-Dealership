using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public string Message;
  public int Price;
  public int Miles;

  public Car(string makeModel, string message, int price, int miles)
  {
    MakeModel = makeModel;
    Message = message;
    Price = price;
    Miles = miles;
  }
  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return (Price < maxPrice && Miles < maxMiles);
  }
}
public class Program
{ 
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", "Retro and cool!", 1100, 368792);
    Car yugo = new Car("1980 Yugo Koral", "Yugo Fast!", 700, 56000);
    Car ford = new Car("1988 Ford Country Squire", "A Classic!", 1400, 239001);
    Car amc = new Car("1976 AMC Pacer", "Pace Yourself!", 400, 198000);

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter Maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter Maximum miles: ");
    int maxMiles = int.Parse(Console.ReadLine());

    List<Car> CarsMatchingSearch = new List<Car>(0);
    bool noMatches = true;
    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
        noMatches = false;
      }
      else 
      {
        noMatches = true;
      }
    }

    if (noMatches) {
      Console.WriteLine("There are no cars within your search.");
    } 

    foreach (Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }

    foreach (Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.Message);
    }
  }
}         