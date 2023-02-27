using System.Collections.Generic;
using System.Linq;
using System;

namespace Bakery.Sales.Models
{
  public class BakeOrder 
  {
    public int OrderCost {get; set;}
    public string FoodType {get; set;}
    public BreadOrder ( int FoodNum)
    {
      if (FoodType == "bread")
      {
        if ((FoodNum) % 3 == 0)
      {
        int FoodNumTrue = (FoodNum-(FoodNum/3));
        OrderCost = FoodNumTrue * 5;
      }
      else if (((FoodNum) % 3 != 0)&&(FoodNum > 3))
      {
        int FoodExtra = 0;
        while (FoodNum % 3 != 0)
        {
          FoodExtra++;
          FoodNum--;
        }
        int FoodNumTrue = (FoodNum-(FoodNum/3));
        OrderCost = (FoodNumTrue + FoodExtra) * 5;
      }
      else 
      {
        OrderCost = FoodNum * 5;
      }
      }
      else
      {
        Console.WriteLine("Our shop sadly doesn't sell that right now, did you want bread and/or pastries?");
      }
    }
  }
}