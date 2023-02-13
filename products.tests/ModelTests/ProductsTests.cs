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
      BreadOrder Fresh = new BreadOrder(1);
      Assert.AreEqual(10, Fresh.BreadCost);
    }
  }
}