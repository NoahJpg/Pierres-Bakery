using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class CinnamomRollTests
  {
    // Test methods go here
    [TestMethod]
    public void CinnamonRollPrice_ReturnsCorrectPriceForOneCinnamonRoll_Seven()
    {
      // Arrange
      CinnamonRoll cinnamonRoll = new CinnamonRoll(1);
      double expectedPrice = 7;
      // Act
      double actualPrice = cinnamonRoll.Price;
      // Assert
      Assert.AreEqual(expectedPrice, actualPrice);
    }

  }
}