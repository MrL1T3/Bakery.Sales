using System.Collections.Generic;
using System.Linq;
using System;

namespace Bakery.Sales.Models
{
  public class BakeOrder 
  {
    public int OrderCost {get; set;}
    public string FoodType {get; set;}
    public BakeOrder (string FoodChoice, int FoodNum)
    {
      FoodType = FoodChoice;
      int FreeNum = 0;
      int UnitCost = 0;
      if (FoodType == "bread")
      {
        FreeNum = 3;
        UnitCost = 5;
      }
      else if (FoodType == "pastry")
      {
        FreeNum = 4;
        UnitCost = 2;
      }
      else
      {
        Console.WriteLine("Our shop sadly doesn't sell that right now, did you want bread or pastries?");
      }

      if ((FoodNum) % FreeNum == 0)
      {
        int FoodNumTrue = (FoodNum-(FoodNum/FreeNum));
        OrderCost = FoodNumTrue * UnitCost;
      }
      else if (((FoodNum) % FreeNum != 0)&&(FoodNum > FreeNum))
      {
        int FoodExtra = 0;
        while (FoodNum % FreeNum != 0)
        {
          FoodExtra++;
          FoodNum--;
        }
        int FoodNumTrue = (FoodNum-(FoodNum/FreeNum));
        OrderCost = (FoodNumTrue + FoodExtra) * UnitCost;
      }
      else 
      {
        OrderCost = FoodNum * UnitCost;
      }
    }
  } 
}