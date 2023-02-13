using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Sales.Models;

namespace Products.Tests
{
  [TestClass]
  public class BreadCostTests
  {
    [TestMethod]
    public void IsBreadCost_EqualToTen_True()
    {
      int BreadCostTest = 10;
      BreadOrder Fresh = new BreadOrder(BreadCostTest);
      Assert.AreEqual(BreadCostTest, Fresh.BreadCost);
    }
  }
}