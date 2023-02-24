using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // Test methods go here
    [TestMethod]
    public void BreadPrice_ReturnsCorrectPriceForOneLoaf_Five()
    {
      // Arrange
      Bread bread = new Bread(1);
      decimal expectedPrice = 5;
      // Act
      decimal actualPrice = bread.Price;
      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);

    }
  }
}