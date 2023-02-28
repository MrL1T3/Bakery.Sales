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
      int InputAmount = Int32.Parse(Console.ReadLine());
      BreadOrder Bread = new BreadOrder(InputAmount);
      int Breadcost = Bread.OrderCost;
      Console.WriteLine("Your order will cost " + Breadcost + " dollars.");
      Main();
    }
  }
}