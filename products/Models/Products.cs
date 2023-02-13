using System.Collections.Generic;
using System.Linq;

namespace Bakery.Sales.Models
{
  public class BreadOrder 
  {
    public int BreadCost {get; set;}
    public BreadOrder (int BreadNum)
    {
      BreadCost = BreadNum * 10;
    }
  } 
}