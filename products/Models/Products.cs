using System.Collections.Generic;
using System.Linq;

namespace Bakery.Sales.Models
{
  public class BreadOrder 
  {
    public int BreadCost {get; set;}
    public BreadOrder (int BreadNum)
    {
      // div by 3 -> always same price
      
      if ((BreadNum) % 3 == 0)
      {
        int BreadNumTrue = (BreadNum-(BreadNum/3));
        BreadCost = BreadNumTrue * 5;
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
        BreadCost = (BreadNumTrue + BreadExtra) * 5;
      }
      else 
      {
        BreadCost = BreadNum * 5;
      }
    }
  } 
}