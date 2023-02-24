using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public double Price { get; private set; }

    public Pastry(int quantity)
    {
      Quantity = quantity;
      Price = 2;
    }

    public double CalculatePrice()
    {
      double pastryDiscount = Quantity * Price; // Calculates price with no discount
      if (Quantity >= 4)
      {
        pastryDiscount -= (Quantity / 4 ) * Price; // Calculates the discount by multiplying the number pastry sets by 2, and subtracts it from the total
      }
      return pastryDiscount;
    }
  }
  

}