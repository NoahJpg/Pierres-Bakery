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
      double expectedPrice = 5;
      // Act
      double actualPrice = bread.Price;
      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);

    }

    [TestMethod]
    public void BreadPrice_ReturnsCorrectPriceForTwoLoves_Ten()
    {
      // Arrange
      Bread bread = new Bread(2);
      double expectedPrice = 10;

      // Act
      double actualPrice = bread.CalculatePrice();

      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
  }
}