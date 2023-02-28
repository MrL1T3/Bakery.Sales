using System.Collections.Generic;
using System.Linq;
using System;

namespace Bakery.Sales.Models
{
  public class BreadOrder 
  {
    public string FoodNum {get; set;}
    public int FreeNum = 3;
    public int UnitCost = 5;
    public int OrderCost = 0;
    public BreadOrder(int FoodNum)
    {}
    public void BreadCost(int FoodNum)
    {
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
  public class PastryOrder 
  {
    public string FoodNum {get; set;}
    public int FreeNum = 4;
    public int UnitCost = 2;
    public int OrderCost = 0;
    public PastryOrder(int FoodNum)
    {}
    public void PastryCost(int FoodNum)
    {
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