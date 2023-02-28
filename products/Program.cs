using System;
using Bakery.Sales.Models;

namespace Bakery.Sales
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("We sell loaves of bread and individual pastries,");
      Console.WriteLine("How many loaves of bread would you like?");
      int BreadAmount = Int32.Parse(Console.ReadLine());
      BreadOrder Bread = new BreadOrder(BreadAmount);
      Bread.BreadCost(BreadAmount);
      int Breadcost = Bread.OrderCost;
      Console.WriteLine("How many pastries would you like?");
      int PastryAmount = Int32.Parse(Console.ReadLine());
      PastryOrder Pastries = new PastryOrder(PastryAmount);
      Pastries.PastryCost(PastryAmount);
      int PastryCost = Pastries.OrderCost;
      Console.WriteLine("Your order will cost " + (Breadcost + PastryCost) + " dollars.");
    }
  }
}