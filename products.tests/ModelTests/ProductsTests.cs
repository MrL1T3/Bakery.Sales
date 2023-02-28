using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Sales.Models;

namespace Products.Tests
{
  [TestClass]
  public class BreadCostTests
  {
    [TestMethod]
    public void IsBreadCost_EqualToFive_True()
    {
      BreadOrder Fresh = new BreadOrder(1);
      Fresh.BreadCost(1);
      Assert.AreEqual(5, Fresh.OrderCost);
    }
    [TestMethod]
    public void IsBreadCost_EqualToTen_True()
    {
      BreadOrder Fresh = new BreadOrder(3);
      Fresh.BreadCost(3);
      Assert.AreEqual(10, Fresh.OrderCost);
    }
    [TestMethod]
    public void IsBreadCost_EqualToTwenty_True()
    {
      BreadOrder Fresh = new BreadOrder(5);
      Fresh.BreadCost(5);
      Assert.AreEqual(20, Fresh.OrderCost);
    }
    [TestMethod]
    public void IsPastryCost_EqualToSix_True()
    {
      PastryOrder Fresh = new PastryOrder(4);
      Fresh.PastryCost(4);
      Assert.AreEqual(6, Fresh.OrderCost);
    }
  }
}