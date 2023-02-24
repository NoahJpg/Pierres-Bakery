using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public double Price { get; }
    
    public Bread(int quantity)
    {
      Quantity = quantity;
      Price = CalculatePrice();
    }

    public double CalculatePrice()
    {
      int loafDiscount = (Quantity / 3) * 2 + Quantity % 3; // groups loaves into threes, but only uses the price of two of them
      return loafDiscount * Price; // determines the cost including discount
    }
  }

}