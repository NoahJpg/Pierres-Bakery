using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryPrice_ReturnsCorrectPriceForOnePastry_Two()
    {
      // Arrange
      Pastry pastry = new Pastry(1);
      double expectedPrice = 2;
      // Act
      double actualPrice = pastry.CalculatePrice();
      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
    [TestMethod]
    public void PastryPrice_ReturnsCorrectPriceForTwoPastries_Four()
    {
      // Arrange
      Pastry pastry = new Pastry(2);
      double expectedPrice = 4;
      // Act
      double actualPrice = pastry.CalculatePrice();
      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
    [TestMethod]
    public void PastryPrice_ReturnsCorrectPriceForThreePastries_Six()
    {
      // Arrange
      Pastry pastry = new Pastry(3);
      double expectedPrice = 6;
      // Act
      double actualPrice = pastry.CalculatePrice();
      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
    [TestMethod]
    public void PastryPrice_ReturnsCorrectPriceForFourPastries_Six()
    {
      // Arrange
      Pastry pastry = new Pastry(4);
      double expectedPrice = 6;
      // Act
      double actualPrice = pastry.CalculatePrice();
      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
    [TestMethod]
    public void PastryPrice_ReturnsCorrectPriceForFivePastries_Eight()
    {
      // Arrange
      Pastry pastry = new Pastry(5);
      double expectedPrice = 8;
      // Act
      double actualPrice = pastry.CalculatePrice();
      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
    [TestMethod]
    public void PastryPrice_ReturnsCorrectPriceForSixPastries_Ten()
    {
      // Arrange
      Pastry pastry = new Pastry(6);
      double expectedPrice = 10;
      // Act
      double actualPrice = pastry.CalculatePrice();
      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
    [TestMethod]
    public void PastryPrice_ReturnsCorrectPriceForSevenPastries_Twelve()
    {
      // Arrange
      Pastry pastry = new Pastry(7);
      double expectedPrice = 12;
      // Act
      double actualPrice = pastry.CalculatePrice();
      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
        [TestMethod]
    public void PastryPrice_ReturnsCorrectPriceForEightPastries_Twelve()
    {
      // Arrange
      Pastry pastry = new Pastry(8);
      double expectedPrice = 12;
      // Act
      double actualPrice = pastry.CalculatePrice();
      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }
  }
}