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
    [TestMethod]
    public void BreadPrice_ReturnsCorrectPriceForThreeLoves_Ten()
    {
      // Arrange
      Bread bread = new Bread(3);
      double expectedPrice = 10;

      // Act
      double actualPrice = bread.CalculatePrice();

      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
    [TestMethod]
    public void BreadPrice_ReturnsCorrectPriceForFourLoves_Fifteen()
    {
      // Arrange
      Bread bread = new Bread(4);
      double expectedPrice = 15;

      // Act
      double actualPrice = bread.CalculatePrice();

      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
    [TestMethod]
    public void BreadPrice_ReturnsCorrectPriceForFiveLoves_Fifteen()
    {
      // Arrange
      Bread bread = new Bread(5);
      double expectedPrice = 20;

      // Act
      double actualPrice = bread.CalculatePrice();

      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
    [TestMethod]
    public void BreadPrice_ReturnsCorrectPriceForSixLoves_Fifteen()
    {
      // Arrange
      Bread bread = new Bread(6);
      double expectedPrice = 20;

      // Act
      double actualPrice = bread.CalculatePrice();

      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
  }
}