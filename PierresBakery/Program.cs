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
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      string[] welcome = 
      { @"
        __                                     __                         
       /  | /                     /          |/  |      /                 
      (___|   ___  ___  ___  ___     ___     |___| ___ (     ___  ___     
      |    | |___)|   )|   )|___)   |___     |   )|   )|___)|___)|   )   )
      |    | |__  |    |    |__      __/     |__/ |__/|| \  |__  |    \_/ 
                                                                      /  ", 
      "                             Welcome to Pierre's Bakery!", 
      "    ",
      " We have the BEST dough in the Northern Hemisphere!", 
      " And a great sale on Bread and Pastries right now.", 
      " Bread is $5 each or Buy 2, get 1 free.", 
      " Pastries are $2 each or Buy 3, get 1 free."
      };
      foreach (string line in welcome)
      {
        Console.WriteLine(line);
        Thread.Sleep(1400);
      }
      Console.WriteLine(" ");
      Console.WriteLine(" How many loaves of Bread would you like today? :)  ");
      int breadQuantity = int.Parse(Console.ReadLine());

      Console.WriteLine(" How many pastries would you like? ");
      int pastryQuantity = int.Parse(Console.ReadLine());

      Console.WriteLine(" How many Cinnamon Rolls would you like today?");
      int cinnamonRollQuantity = int.Parse(Console.ReadLine());

      CinnamonRoll cinnamonRoll = new CinnamonRoll(cinnamonRollQuantity);
      Bread bread = new Bread(breadQuantity);
      Pastry pastry = new Pastry(pastryQuantity);

      Console.ForegroundColor = ConsoleColor.Green;
      string[] checkout = 
      {
      $" {breadQuantity} Loaves of Bread: ${bread.CalculatePrice()}", 
      $" {pastryQuantity} Pastries: ${pastry.CalculatePrice()}", 
      $" {cinnamonRollQuantity} Cinnamon Rolls: ${cinnamonRoll.CalculatePrice()}",
      " ______________________________", 
      $" Total: ${bread.CalculatePrice() + pastry.CalculatePrice() + cinnamonRoll.CalculatePrice()}",
      " ",
      " Thanks for coming in today.", 
      " Hope to see you again soon!"
      };
      foreach (string line in checkout)
      {
        Console.WriteLine(line);
        Thread.Sleep(1000);
      }
    }
  }
}