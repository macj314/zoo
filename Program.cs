using System;
using System.Collections.Generic;
using Zoo.Sites;

namespace Zoo
{
  public class Program
  {
    public static void Main()
    {
      //Instantiate zoo object: Zoo zoo = new Zoo();
      //Fill zoo with enclosures
      Enclosures tiger = new Enclosures("Sumatran Tiger", "Lourlo", 5);
      Console.WriteLine(tiger.DisplayAnimal());
      Console.WriteLine("Hello! Welcome to Zalando Zoo! We have many sites and attractions that you can see.");
      Console.WriteLine("Our list of enclosures are:" + Environment.NewLine + "-------------------------------");
      //list out enclosures with zoo object
      // while(bool flag == true)
      // {
      string input = Console.ReadLine(); //try to get a string that matches a name to one of the enclosures listed
      //if input invalid: print "Sorry that's not one of our enclosures, please try again
      // }
    }
  }
}