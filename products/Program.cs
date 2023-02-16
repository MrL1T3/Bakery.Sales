using System;
using Bakery.Sales.Models;

namespace Bakery.Sales
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Would you like to order bread or pastries?");
      string inputProduct = Console.ReadLine();
      Console.WriteLine("And how many of that would you like?");
      int inputAmount = Int32.Parse(Console.ReadLine());
      BakeOrder Fresh = new BakeOrder(inputProduct, inputAmount);
      int cost = Fresh.OrderCost;
      Console.WriteLine("Your order will cost " + cost + " dollars.");
      Main();
    }
  }
}