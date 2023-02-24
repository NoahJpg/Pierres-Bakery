using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] lines = {@"  __                                     __                         
 /  | /                     /          |/  |      /                 
(___|   ___  ___  ___  ___     ___     |___| ___ (     ___  ___     
|    | |___)|   )|   )|___)   |___     |   )|   )|___)|___)|   )   )
|    | |__  |    |    |__      __/     |__/ |__/|| \  |__  |    \_/ 
                                                                 /  ", "Welcome to Pierre's Bakery!", "We have the BEST dough in the Northern Hemisphere!", "And a great sale on Bread and Pastries right now.", "Bread is $5 each or Buy 2, get 1 free.", "Pastries are $2 each or Buy 3, get 1 free."};
      foreach (string line in lines)
      {
        Console.WriteLine(line);
        Thread.Sleep(1500);
      }

      Console.WriteLine("How many loaves of Bread would you like today? :)  ");
      int breadQuantity = int.Parse(Console.ReadLine());

      Console.WriteLine("How many pastries would you like? ");
      int pastryQuantity = int.Parse(Console.ReadLine());

      Bread bread = new Bread(breadQuantity);
      Pastry pastry = new Pastry(pastryQuantity);

      string[] lines2 = {$"Total cost for {breadQuantity} loaves of Bread: ${bread.Price}", $"Total cost for {pastryQuantity} Pastries: ${pastry.Price}", $"Total cost for your order: ${bread.Price + pastry.Price}"};
      foreach (string line in lines2)
      {
        Console.WriteLine(line);
        Thread.Sleep(1000);
      }
    }
  }
}