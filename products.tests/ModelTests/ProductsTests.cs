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
      Assert.AreEqual(5, Fresh.BreadCost);
    }
    [TestMethod]
    public void IsBreadCost_EqualToTen_True()
    {
      BreadOrder Fresh = new BreadOrder(3);
      Assert.AreEqual(10, Fresh.BreadCost);
    }
    [TestMethod]
    public void IsBreadCost_EqualToTwenty_True()
    {
      BreadOrder Fresh = new BreadOrder(5);
      Assert.AreEqual(20, Fresh.BreadCost);
    }
    
  }
}