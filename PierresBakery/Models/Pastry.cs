using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public double Price { get; }

    public Pastry(int quantity)
    {
      Quantity = quantity;
      Price = CalculatePrice();
    }

    public double CalculatePrice()
    {
      int pastryDiscount = Quantity * 2; // Calculates price with no discount
      if (Quantity >= 4)
      {
        pastryDiscount -= (Quantity / 4 ) * 2; // Calculates the discount by multiplying the number pastry sets by 2, and subtracts it from the total
      }
      return pastryPrice * Price;
    }
  }
  

}