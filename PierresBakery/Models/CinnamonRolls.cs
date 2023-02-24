using System;

namespace PierresBakery.Models
{
  public class CinnamonRoll
  {
    public int Quantity { get; set; }
    public double Price { get; private set; }
    
    public CinnamonRoll(int quantity)
    {
      Quantity = quantity;
      Price = 7;
    }

    public double CalculatePrice()
    {
      double amount = Price * Quantity;
      return amount;
    }

  }
}