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
      BakeOrder Fresh = new BakeOrder("bread", 1);
      Assert.AreEqual(5, Fresh.OrderCost);
    }
    [TestMethod]
    public void IsBreadCost_EqualToTen_True()
    {
      BakeOrder Fresh = new BakeOrder("bread", 3);
      Assert.AreEqual(10, Fresh.OrderCost);
    }
    [TestMethod]
    public void IsBreadCost_EqualToTwenty_True()
    {
      BakeOrder Fresh = new BakeOrder("bread", 5);
      Assert.AreEqual(20, Fresh.OrderCost);
    }
    [TestMethod]
    public void IsPastry_True()
    {
      BakeOrder Fresh = new BakeOrder("pastry", 1);
      Assert.AreEqual("pastry", Fresh.FoodType);
    }
    [TestMethod]
    public void IsPastryCost_EqualToSix_True()
    {
      BakeOrder Fresh = new BakeOrder("pastry", 4);
      Assert.AreEqual(6, Fresh.OrderCost);
    }
  }
}