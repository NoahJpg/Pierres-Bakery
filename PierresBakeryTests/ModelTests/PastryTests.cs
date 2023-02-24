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
      double actualPrice = pastry.Price;
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
      double actualPrice = pastry.Price;
      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }

  }
}