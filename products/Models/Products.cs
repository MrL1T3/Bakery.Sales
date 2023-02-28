using System.Collections.Generic;
using System.Linq;
using System;

namespace Bakery.Sales.Models
{
  public class BreadOrder 
  {
    public int OrderCost {get; set;}
    public string FoodNum {get; set;}
    public BreadOrder ( int BreadNum)
    {
      if (BreadNum > 0)
      {
        if ((BreadNum) % 3 == 0)
        {
          int BreadNumTrue = (BreadNum-(BreadNum/3));
          OrderCost = BreadNumTrue * 5;
        }
        else if (((BreadNum) % 3 != 0)&&(BreadNum > 3))
        {
          int BreadExtra = 0;
          while (BreadNum % 3 != 0)
          {
            BreadExtra++;
            BreadNum--;
          }
          int BreadNumTrue = (BreadNum-(BreadNum/3));
          OrderCost = (BreadNumTrue + BreadExtra) * 5;
        }
        else 
        {
          OrderCost = BreadNum * 5;
        }
      }
    }
  }
}
