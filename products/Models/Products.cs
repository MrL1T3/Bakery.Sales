using System.Collections.Generic;
using System.Linq;
using System;

namespace Bakery.Sales.Models
{
  public class BreadOrder 
  {
    public int OrderCost {get; set;}
    public string BreadNum {get; set;}
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
  public class PastryOrder 
  {
    public int OrderCost {get; set;}
    public string PastryNum {get; set;}
    public PastryOrder ( int PastryNum)
    {
      if (PastryNum > 0)
      {
        if ((PastryNum) % 4 == 0)
        {
          int PastryNumTrue = (PastryNum-(PastryNum/4));
          OrderCost = PastryNumTrue * 2;
        }
        else if (((PastryNum) % 4 != 0)&&(PastryNum > 4))
        {
          int PastryExtra = 0;
          while (PastryNum % 4 != 0)
          {
            PastryExtra++;
            PastryNum--;
          }
          int PastryNumTrue = (PastryNum-(PastryNum/4));
          OrderCost = (PastryNumTrue + PastryExtra) * 2;
        }
        else 
        {
          OrderCost = PastryNum * 2;
        }
      }
    }
  }
}
