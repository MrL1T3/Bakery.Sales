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
      int inputAmount = Int32.Parse(Console.ReadLine());
      BreadOrder Bread = new BreadOrder(inputAmount);
      int cost = Bread.OrderCost;
      Console.WriteLine("Your order will cost " + cost + " dollars.");
      Main();
    }
  }
}